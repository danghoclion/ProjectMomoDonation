using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectMomoDonation.Core.Data.SeedData;
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
        public DbSet<OrganizationFundraise> OrganazationFundraise { get; set; }
        public DbSet<ProgramDonation> ProgramDonations { get; set; }

        public MomoDbContext()
        {
        }

        public MomoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DangHocPC;Database=MomoDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedingData();
        }
    }
}