using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Models
{
    public class DonateHistory
    {
        public string Id { get; set; }
        public int ProgramDonationId { get; set; }
        public decimal Amount { get; set; }

        public virtual ProgramDonation? ProgramDonation { get; set; }
        public virtual MomoUser? MomoUser { get; set; }
    }
}
