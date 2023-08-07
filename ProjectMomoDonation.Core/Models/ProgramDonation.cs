using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Models
{
    public enum Status
    {

    }
    public class ProgramDonation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Story { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal? TotalDonate { get; set; }
        public decimal DonationGoal { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public int OrganaziFundraiseId { get; set; }
        public virtual Category Category { get; set; }
        public virtual OrganizationFundraise OrganaziFundraise { get; set; }
        public virtual ICollection<DonateHistory> DonateHistorys { get; set; }
    }
}
