namespace ProjectMomoDoanation.Core.Interface
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