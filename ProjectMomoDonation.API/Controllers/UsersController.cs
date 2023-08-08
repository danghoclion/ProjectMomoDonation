using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Models;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UsersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var users = await unitOfWork.MomoUserRepository.GetAllAsync();
            return Ok(users);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var users = await unitOfWork.MomoUserRepository.GetByIdAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] UserDTO userDTO)
        {
            var users = mapper.Map<MomoUser>(userDTO);
            var newusers = await unitOfWork.MomoUserRepository.CreateAsync(users);

            if (newusers == null)
            {
                return NotFound();
            }

            return Ok(newusers);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UserDTO usersDTO)
        {
            var users = mapper.Map<MomoUser>(usersDTO);
            users.Id = id;
            var updateusers = await unitOfWork.MomoUserRepository.UpdateAsync(users);

            if (updateusers == null)
                return NotFound();
            return Ok(mapper.Map<UserDTO>(updateusers));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {

            var delete = unitOfWork.MomoUserRepository.GetByWhereAsync(d => d.Id == id).First();
            if (delete == null)
                return NotFound();
            await unitOfWork.MomoUserRepository.Deletesync(delete);
            return Ok(mapper.Map<UserDTO>(delete));
        }
    }
}
