using Microsoft.AspNetCore.Mvc;
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
    public class DonateHistoryRepository : GenericRepository<DonateHistory>, IDonateHistoryRepository
    {
        public DonateHistoryRepository()
        { }

        public DonateHistoryRepository(MomoDbContext context) : base(context)
        {
        }

        public async Task<List<DonateHistory>?> GetByUrlSlugProgram(string urlslug)
        {
            var program = context.ProgramDonations.Where(x => x.UrlSlug== urlslug).FirstOrDefault();
            if (program == null) 
            {
                return null;
            }
            var donateHistory = await entities.Where(x => x.ProgramDonationId == program.Id).ToListAsync();
            return donateHistory;
        }

        public async Task<List<DonateHistory>> GetByUserName(string name)
        {
            var user = context.Users.Where(x => x.UserName==name).FirstOrDefault();
            var donateHistory = await entities.Where(x => x.Id == user.Id).ToListAsync();

            if(donateHistory == null) { return null; }
            return donateHistory;
        }
    }
}