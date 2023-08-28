using ProjectMomoDonation.Core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Models
{
    public class ProgramDonation
    {
        public int Id { get; set; }
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
        public int CategoryId { get; set; }
        public int OrganizationFundraiseId { get; set; }

        [NotMapped]
        public Category? Category { get; set; }

        public OrganizationFundraise? OrganizationFundraise { get; set; }
        public virtual ICollection<DonateHistory>? DonateHistorys { get; set; }
    }
}