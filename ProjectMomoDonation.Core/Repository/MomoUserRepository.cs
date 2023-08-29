using ProjectMomoDoanation.Core.Repository;
using ProjectMomoDonation.Core.Data;
using ProjectMomoDonation.Core.Interface;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Repository
{
    public class MomoUserRepository : GenericRepository<MomoUser>, IMomoUserRepository
    {
        public MomoUserRepository() { }

        public MomoUserRepository(MomoDbContext context) : base(context)
        {
        }
    }
}
