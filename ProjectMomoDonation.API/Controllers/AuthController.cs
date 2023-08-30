using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<MomoUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<MomoUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDto)
        {
            var identityUser = new MomoUser
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
                        return Ok();
                }
            }

            return BadRequest();
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
                            RoleName = roles.ToList(),
                            Status = user.Status
                        };
                        return Ok(response);
                    }
                }
            }

            return BadRequest("Username or password incorrect");
        }

        [HttpPut]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO model)
        {
            var user = await userManager.FindByEmailAsync(model.userName);
            if (user != null)
            {
                var changePasswordResult = await userManager.ChangePasswordAsync(user, model.oldPassword, model.newPassword);
                if (changePasswordResult.Succeeded)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword()
        {
            return Ok();
        }
    }
}