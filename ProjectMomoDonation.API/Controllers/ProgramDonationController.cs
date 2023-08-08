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
    public class ProgramDonationController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProgramDonationController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var programs = await unitOfWork.ProgramDonation.GetAllAsync();
            return Ok(programs);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var program = await unitOfWork.ProgramDonation.GetByIdAsync(id);
            if (program == null)
            {
                return NotFound();
            }
            return Ok(program);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] ProgramDonateDTO programDTO)
        {
            var program = mapper.Map<MomoUser>(programDTO);
            var newProgram = await unitOfWork.MomoUserRepository.CreateAsync(program);

            if (newProgram == null)
            {
                return NotFound();
            }

            return Ok(newProgram);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProgramDonateDTO programDTO)
        {
            var program = mapper.Map<ProgramDonation>(programDTO);
            program.Id = id;
            var update = await unitOfWork.ProgramDonation.UpdateAsync(program);

            if (update == null)
                return NotFound();
            return Ok(mapper.Map<UserDTO>(update));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var delete = await unitOfWork.ProgramDonation.GetByIdAsync(id);
            if (delete == null)
                return NotFound();
            await unitOfWork.ProgramDonation.Deletesync(delete);
            return Ok(mapper.Map<ProgramDonateDTO>(delete));
        }
    }
}
