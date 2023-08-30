using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;

        public UsersController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var users =await unitOfWork.MomoUserRepository.GetAllAsync();
            return Ok(users);
        }

        [HttpPost]
        [Route("Block")]
        public async Task<IActionResult> BlockUser(string userName)
        {
            var user = unitOfWork.MomoUserRepository.GetByWhereAsync(x => x.UserName == userName).FirstOrDefault();
            user.Status = "Block";
            unitOfWork.SaveChange();
            return Ok();
        }
    }
}
