﻿using AutoMapper;
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
        public async Task<IActionResult> GetALL()
        {
            var programs = await unitOfWork.ProgramDonation.GetAllAsync();
            
            var listResult = mapper.Map<List<ProgramDonateDTO>>(programs);
            foreach (var item in programs)
            {
                var category = await unitOfWork.CategoryRepository.GetByIdAsync(item.CategoryId);
                var organition = await unitOfWork.OrganazationFundraise.GetByIdAsync(item.OrganizationFundraiseId);
                var historyDonation = unitOfWork.DonateHistoryRepository.GetByWhereAsync(x => x.ProgramDonationId == item.Id).Count();
                foreach(var result in listResult)
                {
                    result.CategoryName = category.Name;
                    result.OrganizationName = organition.Name;
                    result.OrganizationAvatar = organition.Avatar;
                    result.CountDonation = historyDonation;
                }
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
