using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Models;
using System.Text.Json;

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
        [Route("filter")]
        public async Task<IActionResult> GetALL([FromQuery] int? categoryId, [FromQuery] int? organitionId)
        {
            var programs = await unitOfWork.ProgramDonation.GetAllAsync();

            if (categoryId != null)
            {
                programs = await unitOfWork.ProgramDonation.GetProgramsByCategory(categoryId);
            }
            if (organitionId != null)
            {
                programs = await unitOfWork.ProgramDonation.GetProgramsByOrganition(organitionId);
            }
            var listResult = mapper.Map<List<ProgramDonateDTO>>(programs);
            for (int i = 0; i < listResult.Count; i++)
            {
                var category = await unitOfWork.CategoryRepository.GetByIdAsync(programs[i].CategoryId);
                var organition = await unitOfWork.OrganazationFundraise.GetByIdAsync(programs[i].OrganizationFundraiseId);
                var historyDonation = unitOfWork.DonateHistoryRepository.GetByWhereAsync(x => x.ProgramDonationId == programs[i].Id).Count();
                listResult[i].CategoryName = category.Name;
                listResult[i].OrganizationName = organition.Name;
                listResult[i].OrganizationAvatar = organition.Avatar;
                listResult[i].CountDonation = historyDonation;
            }
            return Ok(listResult);
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

        [HttpGet]
        [Route("GetLastest")]
        public async Task<IActionResult> GetLastest([FromQuery]int size)
        {
            var program = await unitOfWork.ProgramDonation.GetProgramLaster(size);
            if (program == null)
            {
                return NotFound();
            }
            return Ok(program);
        }

        [HttpGet]
        public async Task<IActionResult> GetByUrlSlug([FromQuery] string urlSlug)
        {
            var program = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.UrlSlug.Contains(urlSlug));
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
            var program = mapper.Map<ProgramDonation>(programDTO);
            var newProgram = await unitOfWork.ProgramDonation.CreateAsync(program);

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