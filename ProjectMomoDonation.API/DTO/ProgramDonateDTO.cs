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
        public int CategoryName { get; set; }
        public int OrganizationName { get; set; }
        public string OrganizationAvatar { get; set; }
        public string CountDonation { get; set;}
    }
}
