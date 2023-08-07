using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Models
{
    public class MomoUser : IdentityUser
    {
        public string Status { get; set; }

        public virtual ICollection<DonateHistory> DonateHistorys { get; set; }

    }
}
