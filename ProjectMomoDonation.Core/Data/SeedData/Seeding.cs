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
            var contributorRoles = new IdentityRole
            {
                Id = "c77bd53f-97dd-4a06-bc13-ece2df6f5488",
                ConcurrencyStamp = "contributorRoleId",
                Name = "contributor",
                NormalizedName = "contributor".ToUpper()
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
                contributorRoles,
                guestRoles
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // Seed Users
            var adminUser = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            var contributor = new IdentityUser
            {
                UserName = "contributor@gmail.com",
                Email = "contributor@gmail.com",
                EmailConfirmed = true,
            };
            contributor.NormalizedUserName = contributor.UserName.ToUpper();
            contributor.NormalizedEmail = contributor.Email.ToUpper();
            contributor.PasswordHash = passwordHasher.HashPassword(contributor, pwd);

            var member = new IdentityUser
            {
                UserName = "guest@gmail.com",
                Email = "guest@gmail.com",
                EmailConfirmed = true,
            };
            member.NormalizedUserName = member.UserName.ToUpper();
            member.NormalizedEmail = member.Email.ToUpper();
            member.PasswordHash = passwordHasher.HashPassword(member, pwd);

            List<IdentityUser> users = new List<IdentityUser>() {
                adminUser,
                contributor,
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
                RoleId = contributorRoles.Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = guestRoles.Id
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}