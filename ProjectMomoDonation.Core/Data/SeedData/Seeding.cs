using Microsoft.AspNetCore.Identity;
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
                    Avatar = $"https://swiperjs.com/demos/images/nature-{i}.jpg",
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
                    UrlSlug = $"url-{i}" ,
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

            //Auth seed
            var pwd = "123abc";
            var passwordHasher = new PasswordHasher<IdentityUser>();

            //Seed Roles

            var adminRoles = new IdentityRole
            {
                Id = "378b471d-756a-46c2-973b-159f2e64bdac",
                ConcurrencyStamp = "adminRoleId",
                Name = "admin",
                NormalizedName = "admin".ToUpper()
            };

            var guestRoles = new IdentityRole
            {
                Id = "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89",
                ConcurrencyStamp = "guestRoleId",
                Name = "guest",
                NormalizedName = "guest".ToUpper()
            };
            var roles = new List<IdentityRole>()
            {
                adminRoles,

                guestRoles
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // Seed Users
            var adminUser = new IdentityUser
            {
                Id = "8F55A479-468A-480B-9AE9-6B353B2825E0",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            var member = new IdentityUser
            {
                Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                UserName = "guest@gmail.com",
                Email = "guest@gmail.com",
                EmailConfirmed = true,
            };
            member.NormalizedUserName = member.UserName.ToUpper();
            member.NormalizedEmail = member.Email.ToUpper();
            member.PasswordHash = passwordHasher.HashPassword(member, pwd);

            List<IdentityUser> users = new List<IdentityUser>() {
                adminUser,
                member,
            };

            modelBuilder.Entity<IdentityUser>().HasData(users);

            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = adminRoles.Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = guestRoles.Id
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            var donateHistoryList = new List<DonateHistory>();

            for (int i = 1; i < 10; i++)
            {
                var donateHistory = new DonateHistory()
                {
                    HistoryID = i,
                    Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                    ProgramDonationId = i,
                    Time = DateTime.Now.AddHours(i),
                    Amount = i * 200000
                };
                donateHistoryList.Add(donateHistory);
            }
            modelBuilder.Entity<DonateHistory>().HasData(donateHistoryList);
        }
    }
}