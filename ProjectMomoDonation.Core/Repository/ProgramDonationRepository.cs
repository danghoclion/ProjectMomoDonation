using Microsoft.EntityFrameworkCore;
using ProjectMomoDoanation.Core.Interface;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Repository
{
    public class ProgramDonationRepository : GenericRepository<ProgramDonation>, IProgramDonationRepository
    {
        public ProgramDonationRepository()
        { }

        public ProgramDonationRepository(MomoDbContext context) : base(context)
        {
        }

        public async Task<List<ProgramDonation>> GetProgramsByCategory(int? categoryId)
        {
            var program = await entities.Where(x => x.CategoryId == categoryId).ToListAsync();
            return program;
        }

        public async Task<List<ProgramDonation>> GetProgramsByOrganition(int? id)
        {
            var program = await entities.Where(x => x.OrganizationFundraiseId == id).ToListAsync();
            return program;
        }
    }
}