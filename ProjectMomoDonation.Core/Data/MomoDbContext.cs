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
<<<<<<< HEAD
        public DbSet<RegisterRequestDTO> MomoUsers { get; set; }
        public DbSet<OrganizationFundraise> OrganaziFundraise { get;set; }
=======
        public DbSet<MomoUser> MomoUsers { get; set; }
        public DbSet<OrganizationFundraise> OrganazationFundraise { get; set; }
>>>>>>> dc1b3091c2d770521ee1c4f12300843664f68716
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-OJ0HV03;Database=MomoDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;");
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