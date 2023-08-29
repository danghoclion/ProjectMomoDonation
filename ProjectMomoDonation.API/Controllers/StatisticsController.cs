
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMomoDoanation.Core.Interface;
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
        [Route("GetTotalProgram")]
        public async Task<IActionResult> GetTotalProgram()
        {
            var program = await unitOfWork.ProgramDonation.GetAllAsync();
            return Ok(program.Count());
        }

        [HttpGet]
        [Route("GetTotalProgramActive")]
        public async Task<IActionResult> GetTotalProgramActive()
        {
            var program = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.Status == StatusProgram.Active);
            return Ok(program.Count());
        }

        [HttpGet]
        [Route("GetTotalProgramInactive")]
        public async Task<IActionResult> GetTotalProgramInactive()
        {
            var program = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.Status == StatusProgram.Inactive);
            return Ok(program.Count());
        }

        [HttpGet]
        [Route("GetTotalProgramClose")]
        public async Task<IActionResult> GetTotalProgramClose()
        {
            var program = unitOfWork.ProgramDonation.GetByWhereAsync(x => x.Status == StatusProgram.End);
            return Ok(program.Count());
        }

        [HttpGet]
        [Route("NumberDonations")]
        public async Task<IActionResult> GetNumberDonation()
        {
            var donate =await unitOfWork.DonateHistoryRepository.GetAllAsync();
            return Ok(donate.Count());
        }

        [HttpGet]
        [Route("TotalMoneyDonate")]
        public async Task<IActionResult> GetTotalDonate()
        {
            var donateHistories =await unitOfWork.DonateHistoryRepository.GetAllAsync();
            var money = donateHistories.Sum(x => x.Amount);
            return Ok(money);
        }
    }
}
