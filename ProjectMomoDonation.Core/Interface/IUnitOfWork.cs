using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        IDonateHistoryRepository DonateHistory { get; }

        IMomoUserRepository MomoUser { get; }
        IOrganazationFundraiseRepository OrganazationFundraise { get; }

        IProgramDonationRepository ProgramDonation { get; }

        int Save();
    }
}