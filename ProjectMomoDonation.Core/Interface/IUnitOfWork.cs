using ProjectMomoDonation.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }

        IDonateHistoryRepository DonateHistoryRepository { get; }

        IMomoUserRepository MomoUserRepository { get; }
        IOrganazationFundraiseRepository OrganazationFundraise { get; }

        IProgramDonationRepository ProgramDonation { get; }

        int SaveChange();
        Task<int> SaveChangeAsync();
    }
}