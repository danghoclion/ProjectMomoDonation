﻿using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Repository
{
    public class OrganizationFundraiseRepository : GenericRepository<OrganizationFundraise>, IOrganazationFundraiseRepository
    {
        public OrganizationFundraiseRepository()
        { }

        public OrganizationFundraiseRepository(MomoDbContext context) : base(context)
        {
        }
    }
}