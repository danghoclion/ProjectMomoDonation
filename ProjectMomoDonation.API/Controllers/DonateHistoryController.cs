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
    public class DonateHistoryController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DonateHistoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var donateHistories = await unitOfWork.DonateHistoryRepository.GetAllAsync();
            return Ok(donateHistories);
        }

        [HttpGet]
        [Route("GetByUrlslugProgram")]
        public async Task<IActionResult> GetByUrlslugProgram([FromQuery]string urlslug)
        {
            var donateHistories = await unitOfWork.DonateHistoryRepository.GetByUrlSlugProgram(urlslug);
            return Ok(donateHistories);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var donateHistorie = await unitOfWork.DonateHistoryRepository.GetByIdAsync(id);
            if (donateHistorie == null)
            {
                return NotFound();
            }
            return Ok(donateHistorie);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] DonateHistoryDTO donateDTO)
        {
            var donate = mapper.Map<DonateHistory>(donateDTO);
            var newDonate = await unitOfWork.DonateHistoryRepository.CreateAsync(donate);

            if (newDonate == null)
            {
                return NotFound();
            }

            return Ok(newDonate);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var delete = await unitOfWork.DonateHistoryRepository.GetByIdAsync(id);
            if (delete == null)
                return NotFound();
            await unitOfWork.DonateHistoryRepository.Deletesync(delete);
            return Ok(delete);
        }
    }
}
