namespace ProjectMomoDonation.API.DTO
{
    internal class LoginResponseDto
    {
        public LoginResponseDto()
        {
        }
        public string Status { get; set; }
        public string Name { get; set; }
        public string JwtToken { get; set; }
        public List<string> RoleName { get; set; }
    }
}