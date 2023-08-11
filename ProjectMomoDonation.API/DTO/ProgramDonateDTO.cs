namespace ProjectMomoDonation.API.DTO
{
    public class ProgramDonateDTO
    {
        public string Title { get; set; }
        public string AvatarUrl { get; set; }
        public string? UrlSlug { get; set; }
        public string ShortTitle { get; set; }
        public string Story { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal? TotalDonate { get; set; }
        public decimal DonationGoal { get; set; }
        public string Status { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAvatar { get; set; }
        public int CountDonation { get; set; }
    }
}