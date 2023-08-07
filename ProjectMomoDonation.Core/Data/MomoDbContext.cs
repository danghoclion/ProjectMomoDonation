using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Data
{
    public class MomoDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<DonateHistory> DonateHistorys { get; set; }
        public DbSet<MomoUser> MomoUsers { get; set; }
        public DbSet<OrganizationFundraise> OrganaziFundraise { get;set; }
        public DbSet<ProgramDonation> ProgramDonations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DANGHOCPC;Database=MomoDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Seed();
        }
    }
}
