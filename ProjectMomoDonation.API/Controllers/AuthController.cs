using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDto.Username,
                Email = registerRequestDto.Username,
            };

            var result = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

            if (result.Succeeded)
            {
                if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                {
                    result = await userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

                    if (result.Succeeded)
                        return Ok("User was registered, please login");
                }
            }

            return BadRequest("Something went wrong");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequest)
        {
            var user = await userManager.FindByEmailAsync(loginRequest.Username);

            if (user != null)
            {
                var check = await userManager.CheckPasswordAsync(user, loginRequest.Password);

                if (check)
                {
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles != null)
                    {
                        var token = tokenRepository.CreateJWTToken(user, roles.ToList());

                        var response = new LoginResponseDto()
                        {
                            JwtToken = token,
                            Name = loginRequest.Username,
                            Status = "Susscess"
                        };
                        return Ok(response);
                    }
                }
            }

            return BadRequest("Username or password incorrect");
        }
    }
}