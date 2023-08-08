using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDoanation.Core.Repository;
using ProjectMomoDonation.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MomoDbContext context;
        private ICategoryRepository categoryRepository;
        private IDonateHistoryRepository donateHistoryRepository;
        private IMomoUserRepository momoUserRepository;
        private IOrganazationFundraiseRepository organazationFundraise;
        private IProgramDonationRepository programDonation;

        public UnitOfWork()
        {
            context = new MomoDbContext();
        }

        public MomoDbContext DbContext { get { return context; } }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(context);
                return categoryRepository;
            }
        }

        public IDonateHistoryRepository DonateHistoryRepository
        {
            get
            {
                if (donateHistoryRepository == null)
                    donateHistoryRepository = new DonateHistoryRepository(context);
                return donateHistoryRepository;
            }
        }
        public IMomoUserRepository MomoUserRepository
        {
            get
            {
                if (momoUserRepository == null)
                    momoUserRepository = new MomoUserRepository(context);
                return momoUserRepository;
            }
        }
        public IOrganazationFundraiseRepository OrganazationFundraise
        {
            get
            {
                if (organazationFundraise == null)
                    organazationFundraise = new OrganizationFundraiseRepository(context);
                return organazationFundraise;
            }
        }
        public IProgramDonationRepository ProgramDonation
        {
            get
            {
                if (programDonation == null)
                    programDonation = new ProgramDonationRepository(context);
                return programDonation;
            }
        }
        public void Dispose()
        {
            this.context.Dispose();
        }

        public int SaveChange()
        {
            return this.context.SaveChanges();
        }

        public Task<int> SaveChangeAsync()
        {
            return this.context.SaveChangesAsync();
        }
    }
}
