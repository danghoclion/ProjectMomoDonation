using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDoanation.Core.Interface
{
    public interface IProgramDonationRepository : IGenericRepository<ProgramDonation>
    {
        Task<List<ProgramDonation>> GetProgramsByCategory(int? categoryId);
        Task<List<ProgramDonation>> GetProgramsByOrganition(int? id);
        Task<List<ProgramDonation>> GetProgramLaster(int size);
    }
}