﻿namespace ProjectMomoDonation.Core.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProgramDonation> ProgramDonations { get; set; }
    }
}