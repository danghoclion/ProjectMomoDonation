using ProjectMomoDonation.Core.Helper;
using ProjectMomoDonation.Core.UnitOfWork;

namespace ProjectMomoDonation.API.ValidateHelper
{
    public class AutoSetStatusService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var refreshTime = 6000;
            while (!stoppingToken.IsCancellationRequested)
            {
                Helper.SetStatusProgram(unitOfWork);
                await Task.Delay(refreshTime, stoppingToken);
            }
            unitOfWork.SaveChange();
        }
    }
}