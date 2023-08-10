using Microsoft.EntityFrameworkCore;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Data.SeedData
{
    public static class Seeding
    {
        public static void SeedingData(this ModelBuilder modelBuilder)
        {
            var listCategory = new List<Category>() { };
            for (int i = 1; i < 10; i++)
            {
                var item = new Category()
                {
                    CategoryId = i,
                    Description = $"Description + {i}",
                    Name = $"Name +{i}",
                };
                listCategory.Add(item);
            }
            var listOrganization = new List<OrganizationFundraise>() { };
            for (int i = 1; i < 10; i++)
            {
                var item = new OrganizationFundraise()
                {
                    OrganizationFundraiseId = i,
                    Avatar = $"",
                    Description = $"Description + {i}",
                    Name = $"Name +{i}",
                    Image = $"Image +{i}",
                    ShortName = $"Short name +{i}"
                };
                listOrganization.Add(item);
            }
            var listProgramDonation = new List<ProgramDonation>()
            {
            };
            for (int i = 1; i < 10; i++)
            {
                var item = new ProgramDonation()
                {
                    Id = i,
                    AvatarUrl = $"https://swiperjs.com/demos/images/nature-{i}.jpg",
                    CategoryId = 1,
                    DateEnd = DateTime.Now.AddDays(50),
                    DateStart = DateTime.Now,
                    DonationGoal = 500000,
                    OrganizationFundraiseId = i,
                    ShortTitle = $"Tiltle number {i}",
                    Story = $"Story number {i}",
                    Status = string.Empty,
                    Title = $"Tiltle long number {i}",
                    TotalDonate = i * 50000
                };
                listProgramDonation.Add(item);
            }
            modelBuilder.Entity<Category>()
                .HasData(listCategory);
            modelBuilder.Entity<OrganizationFundraise>()
                .HasData(listOrganization);
            modelBuilder.Entity<ProgramDonation>()
                .HasData(listProgramDonation);
        }
    }
}