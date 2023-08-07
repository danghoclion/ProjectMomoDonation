using Microsoft.AspNetCore.Identity;

namespace ProjectMomoDonation.Core.Models
{
    public class MomoUser : IdentityUser
    {
        public string Status { get; set; }

        public virtual ICollection<DonateHistory> DonateHistorys { get; set; }
    }
}