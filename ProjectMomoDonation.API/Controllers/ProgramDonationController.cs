using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.API.ValidateHelper;
using ProjectMomoDonation.Core.Helper;
using ProjectMomoDonation.Core.Models;
using System;
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
            //Helper.SetStatusProgram(unitOfWork);
        }

        [HttpGet]
        [Route("filter")]
        public async Task<IActionResult> GetALL([FromQuery] int? categoryId, [FromQuery] int? organitionId, string? status)
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
            if (status != null)
                programs = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.Status.Equals(status)).ToList();
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
            var result = mapper.Map<ProgramDonateDTO>(program);
            var category = await unitOfWork.CategoryRepository.GetByIdAsync(program.CategoryId);
            var organition = await unitOfWork.OrganazationFundraise.GetByIdAsync(program.OrganizationFundraiseId);
            var historyDonation = unitOfWork.DonateHistoryRepository.GetByWhereAsync(x => x.ProgramDonationId == program.Id).Count();
            result.OrganizationName= organition.Name; 
            result.CategoryName =category.Name;
            result.OrganizationAvatar= organition.Avatar;
            result.CountDonation = historyDonation;
            if (program == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<ProgramDonateDTO>>(program));
        }

        [HttpGet]
        [Route("GetLastest")]
        public async Task<IActionResult> GetLastest([FromQuery] int size)
        {
            var program = await unitOfWork.ProgramDonation.GetProgramLaster(size);
            if (program == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<ProgramDonateDTO>>(program));
        }

        [HttpGet]
        public async Task<IActionResult> GetByUrlSlug([FromQuery] string urlSlug)
        {
            var program = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.UrlSlug.Contains(urlSlug)).First();
            if (program == null)
            {
                return NotFound();
            }
            var listResult = mapper.Map<ProgramDonateDTO>(program);

            var category = await unitOfWork.CategoryRepository.GetByIdAsync(program.CategoryId);
            var organition = await unitOfWork.OrganazationFundraise.GetByIdAsync(program.OrganizationFundraiseId);
            var historyDonation = unitOfWork.DonateHistoryRepository.GetByWhereAsync(x => x.ProgramDonationId == program.Id).Count();
            listResult.CategoryName = category.Name;
            listResult.OrganizationName = organition.Name;
            listResult.OrganizationAvatar = organition.Avatar;
            listResult.CountDonation = historyDonation;

            return Ok(listResult);
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
            var categoryId = unitOfWork.CategoryRepository.GetByWhereAsync(x => x.Name == programDTO.CategoryName).FirstOrDefault();
            var orgazitionId = unitOfWork.OrganazationFundraise.GetByWhereAsync(x => x.Name == programDTO.OrganizationName).FirstOrDefault();
            program.CategoryId = categoryId.CategoryId;
            program.OrganizationFundraiseId = orgazitionId.OrganizationFundraiseId;

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