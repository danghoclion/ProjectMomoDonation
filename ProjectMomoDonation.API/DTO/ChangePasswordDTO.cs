namespace ProjectMomoDonation.API.DTO
{
    public class ChangePasswordDTO
    {
        public string userName { get; set; }

        public string oldPassword { get; set; }

        public string newPassword { get; set; }
    }
}