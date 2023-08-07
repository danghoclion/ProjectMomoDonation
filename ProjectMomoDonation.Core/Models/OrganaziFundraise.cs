﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Models
{
    public class OrganaziFundraise
    {
        public int OrganaziFundraiseId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public string Image { get; set; }

        public virtual ICollection<ProgramDonation> ProgramDonations { get; set; }
    }
}