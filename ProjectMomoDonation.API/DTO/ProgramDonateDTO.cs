namespace ProjectMomoDonation.API.DTO
{
    public class ProgramDonateDTO
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Story { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal? TotalDonate { get; set; }
        public decimal DonationGoal { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationFundraiseId { get; set; }
    }
}
