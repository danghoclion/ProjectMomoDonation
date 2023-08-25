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
    public class OrganizationFundraiseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public OrganizationFundraiseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var organazation = await unitOfWork.OrganazationFundraise.GetAllAsync();
            return Ok(organazation);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var organazation = await unitOfWork.OrganazationFundraise.GetByIdAsync(id);
            if (organazation == null)
            {
                return NotFound();
            }
            return Ok(organazation);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] OrganazationFundraiseDTO fundraiseDTO)
        {
            var organazation = mapper.Map<OrganizationFundraise>(fundraiseDTO);
            var newOrganazation = await unitOfWork.OrganazationFundraise.CreateAsync(organazation);

            if (newOrganazation == null)
            {
                return NotFound();
            }

            return Ok(newOrganazation);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] OrganazationFundraiseDTO fundraiseDTO)
        {
            var organazation = mapper.Map<OrganizationFundraise>(fundraiseDTO);
            organazation.OrganizationFundraiseId = id;
            var updateOrganazation = await unitOfWork.OrganazationFundraise.UpdateAsync(organazation);

            if (updateOrganazation == null)
                return NotFound();
            return Ok(mapper.Map<OrganazationFundraiseDTO>(updateOrganazation));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var delete = await unitOfWork.OrganazationFundraise.GetByIdAsync(id);
            if (delete == null)
                return NotFound();
            await unitOfWork.OrganazationFundraise.Deletesync(delete);
<<<<<<< HEAD
            return Ok(mapper.Map<OrganizationFundraise>(delete));
=======
            return Ok(mapper.Map<OrganazationFundraiseDTO>(delete));
>>>>>>> 3ef7f785c303615d22e308bbad91ae5b1b949c8c
        }
    }
}
