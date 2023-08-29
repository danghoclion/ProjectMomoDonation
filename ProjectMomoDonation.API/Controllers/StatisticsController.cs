using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.API.DTO;
using ProjectMomoDonation.Core.Helper;

namespace ProjectMomoDonation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public StatisticsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetStatistic")]
        public async Task<IActionResult> GetStatistic()
        {
            var totalProgram = await unitOfWork.ProgramDonation.GetAllAsync();
            var allDonateHistory = await unitOfWork.DonateHistoryRepository.GetAllAsync();
            var totalFundraise = allDonateHistory.Sum(x => x.Amount);
            var totalDonationCount = allDonateHistory.Count();

            var responseDTO = new StatisticDTO()
            {
                TotalDonationCount = totalDonationCount,
                TotalFundraise = totalFundraise,
                TotalProgram = totalProgram.Count(),
            };
            return Ok(responseDTO);
        }
    }
}