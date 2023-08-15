using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Interface
{
    public interface IDonateHistoryRepository : IGenericRepository<DonateHistory>
    {
        public Task<List<DonateHistory>?> GetByUrlSlugProgram(string urlslug);
    }
}