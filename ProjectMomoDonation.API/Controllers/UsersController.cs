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
        private readonly List<string> systemAccount = new List<string>() { "admin@gmail.com", "anonymous@system.com" };

        public UsersController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var users = await unitOfWork.MomoUserRepository.GetAllAsync();
            users.RemoveAll(user => systemAccount.Any(accountUser => accountUser == user.UserName));
            return Ok(mapper.Map<List<UserDTO>>(users));
        }

        [HttpPost]
        public async Task<IActionResult> SetUserStatus(string userName, string status)
        {
            var user = unitOfWork.MomoUserRepository.GetByWhereAsync(x => x.UserName == userName).FirstOrDefault();
            user.Status = status;
            unitOfWork.SaveChange();
            return Ok();
        }
    }
}