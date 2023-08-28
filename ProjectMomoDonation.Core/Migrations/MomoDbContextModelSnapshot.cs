﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMomoDonation.Core.Data;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    [DbContext(typeof(MomoDbContext))]
    partial class MomoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "378b471d-756a-46c2-973b-159f2e64bdac",
                            ConcurrencyStamp = "adminRoleId",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89",
                            ConcurrencyStamp = "guestRoleId",
                            Name = "guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "8F55A479-468A-480B-9AE9-6B353B2825E0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e1d80b8-ab19-4972-a2b9-4198771042e0",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEfTnWujD8DG1y1Pr14pmMT6lsSImtMMFVfwwzqMRF8YxQSNDRLrBudl/SilUzx6Ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f2f22ea9-4711-4cbe-9419-019e0152b033",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "15557381-23ce-47b4-aff1-c13345d02f79",
                            Email = "guest@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@GMAIL.COM",
                            NormalizedUserName = "GUEST@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHXhgcm8anC6kBcEDGwj2j6vO0owXTEqD5jfP3gJXnFPxctNZwufJAOhqJUb8CR6Vw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "965b5693-4683-453c-a78e-3db6a10e9322",
                            TwoFactorEnabled = false,
                            UserName = "guest@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8F55A479-468A-480B-9AE9-6B353B2825E0",
                            RoleId = "378b471d-756a-46c2-973b-159f2e64bdac"
                        },
                        new
                        {
                            UserId = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            RoleId = "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Description + 1",
                            Name = "Name +1"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Description + 2",
                            Name = "Name +2"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Description + 3",
                            Name = "Name +3"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Description + 4",
                            Name = "Name +4"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Description + 5",
                            Name = "Name +5"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Description + 6",
                            Name = "Name +6"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Description + 7",
                            Name = "Name +7"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Description + 8",
                            Name = "Name +8"
                        },
                        new
                        {
                            CategoryId = 9,
                            Description = "Description + 9",
                            Name = "Name +9"
                        });
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.DonateHistory", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProgramDonationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("HistoryID");

                    b.HasIndex("Id");

                    b.HasIndex("ProgramDonationId");

                    b.ToTable("DonateHistorys");

                    b.HasData(
                        new
                        {
                            HistoryID = 1,
                            Amount = 200000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 1,
                            Time = new DateTime(2023, 8, 28, 15, 5, 18, 182, DateTimeKind.Local).AddTicks(3036)
                        },
                        new
                        {
                            HistoryID = 2,
                            Amount = 400000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 2,
                            Time = new DateTime(2023, 8, 28, 16, 5, 18, 182, DateTimeKind.Local).AddTicks(3066)
                        },
                        new
                        {
                            HistoryID = 3,
                            Amount = 600000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 3,
                            Time = new DateTime(2023, 8, 28, 17, 5, 18, 182, DateTimeKind.Local).AddTicks(3067)
                        },
                        new
                        {
                            HistoryID = 4,
                            Amount = 800000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 4,
                            Time = new DateTime(2023, 8, 28, 18, 5, 18, 182, DateTimeKind.Local).AddTicks(3069)
                        },
                        new
                        {
                            HistoryID = 5,
                            Amount = 1000000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 5,
                            Time = new DateTime(2023, 8, 28, 19, 5, 18, 182, DateTimeKind.Local).AddTicks(3071)
                        },
                        new
                        {
                            HistoryID = 6,
                            Amount = 1200000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 6,
                            Time = new DateTime(2023, 8, 28, 20, 5, 18, 182, DateTimeKind.Local).AddTicks(3085)
                        },
                        new
                        {
                            HistoryID = 7,
                            Amount = 1400000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 7,
                            Time = new DateTime(2023, 8, 28, 21, 5, 18, 182, DateTimeKind.Local).AddTicks(3086)
                        },
                        new
                        {
                            HistoryID = 8,
                            Amount = 1600000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 8,
                            Time = new DateTime(2023, 8, 28, 22, 5, 18, 182, DateTimeKind.Local).AddTicks(3088)
                        },
                        new
                        {
                            HistoryID = 9,
                            Amount = 1800000m,
                            Id = "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                            ProgramDonationId = 9,
                            Time = new DateTime(2023, 8, 28, 23, 5, 18, 182, DateTimeKind.Local).AddTicks(3089)
                        });
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.OrganizationFundraise", b =>
                {
                    b.Property<int>("OrganizationFundraiseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationFundraiseId"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationFundraiseId");

                    b.ToTable("OrganazationFundraise");

                    b.HasData(
                        new
                        {
                            OrganizationFundraiseId = 1,
                            Avatar = "https://swiperjs.com/demos/images/nature-1.jpg",
                            Description = "Description + 1",
                            Image = "Image +1",
                            Name = "Name +1",
                            ShortName = "Short name +1"
                        },
                        new
                        {
                            OrganizationFundraiseId = 2,
                            Avatar = "https://swiperjs.com/demos/images/nature-2.jpg",
                            Description = "Description + 2",
                            Image = "Image +2",
                            Name = "Name +2",
                            ShortName = "Short name +2"
                        },
                        new
                        {
                            OrganizationFundraiseId = 3,
                            Avatar = "https://swiperjs.com/demos/images/nature-3.jpg",
                            Description = "Description + 3",
                            Image = "Image +3",
                            Name = "Name +3",
                            ShortName = "Short name +3"
                        },
                        new
                        {
                            OrganizationFundraiseId = 4,
                            Avatar = "https://swiperjs.com/demos/images/nature-4.jpg",
                            Description = "Description + 4",
                            Image = "Image +4",
                            Name = "Name +4",
                            ShortName = "Short name +4"
                        },
                        new
                        {
                            OrganizationFundraiseId = 5,
                            Avatar = "https://swiperjs.com/demos/images/nature-5.jpg",
                            Description = "Description + 5",
                            Image = "Image +5",
                            Name = "Name +5",
                            ShortName = "Short name +5"
                        },
                        new
                        {
                            OrganizationFundraiseId = 6,
                            Avatar = "https://swiperjs.com/demos/images/nature-6.jpg",
                            Description = "Description + 6",
                            Image = "Image +6",
                            Name = "Name +6",
                            ShortName = "Short name +6"
                        },
                        new
                        {
                            OrganizationFundraiseId = 7,
                            Avatar = "https://swiperjs.com/demos/images/nature-7.jpg",
                            Description = "Description + 7",
                            Image = "Image +7",
                            Name = "Name +7",
                            ShortName = "Short name +7"
                        },
                        new
                        {
                            OrganizationFundraiseId = 8,
                            Avatar = "https://swiperjs.com/demos/images/nature-8.jpg",
                            Description = "Description + 8",
                            Image = "Image +8",
                            Name = "Name +8",
                            ShortName = "Short name +8"
                        },
                        new
                        {
                            OrganizationFundraiseId = 9,
                            Avatar = "https://swiperjs.com/demos/images/nature-9.jpg",
                            Description = "Description + 9",
                            Image = "Image +9",
                            Name = "Name +9",
                            ShortName = "Short name +9"
                        });
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.ProgramDonation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DonationGoal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrganizationFundraiseId")
                        .HasColumnType("int");

                    b.Property<string>("ShortTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalDonate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrlSlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrganizationFundraiseId");

                    b.ToTable("ProgramDonations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-1.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8369),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8398),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 1,
                            ShortTitle = "Tiltle number 1",
                            Status = "",
                            Story = "Story number 1",
                            Title = "Tiltle long number 1",
                            TotalDonate = 50000m,
                            UrlSlug = "url-1"
                        },
                        new
                        {
                            Id = 2,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-2.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8420),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8421),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 2,
                            ShortTitle = "Tiltle number 2",
                            Status = "",
                            Story = "Story number 2",
                            Title = "Tiltle long number 2",
                            TotalDonate = 100000m,
                            UrlSlug = "url-2"
                        },
                        new
                        {
                            Id = 3,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-3.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8424),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8425),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 3,
                            ShortTitle = "Tiltle number 3",
                            Status = "",
                            Story = "Story number 3",
                            Title = "Tiltle long number 3",
                            TotalDonate = 150000m,
                            UrlSlug = "url-3"
                        },
                        new
                        {
                            Id = 4,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-4.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8427),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8428),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 4,
                            ShortTitle = "Tiltle number 4",
                            Status = "",
                            Story = "Story number 4",
                            Title = "Tiltle long number 4",
                            TotalDonate = 200000m,
                            UrlSlug = "url-4"
                        },
                        new
                        {
                            Id = 5,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-5.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8431),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8431),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 5,
                            ShortTitle = "Tiltle number 5",
                            Status = "",
                            Story = "Story number 5",
                            Title = "Tiltle long number 5",
                            TotalDonate = 250000m,
                            UrlSlug = "url-5"
                        },
                        new
                        {
                            Id = 6,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-6.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8441),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8441),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 6,
                            ShortTitle = "Tiltle number 6",
                            Status = "",
                            Story = "Story number 6",
                            Title = "Tiltle long number 6",
                            TotalDonate = 300000m,
                            UrlSlug = "url-6"
                        },
                        new
                        {
                            Id = 7,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-7.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8445),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8445),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 7,
                            ShortTitle = "Tiltle number 7",
                            Status = "",
                            Story = "Story number 7",
                            Title = "Tiltle long number 7",
                            TotalDonate = 350000m,
                            UrlSlug = "url-7"
                        },
                        new
                        {
                            Id = 8,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-8.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8448),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8448),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 8,
                            ShortTitle = "Tiltle number 8",
                            Status = "",
                            Story = "Story number 8",
                            Title = "Tiltle long number 8",
                            TotalDonate = 400000m,
                            UrlSlug = "url-8"
                        },
                        new
                        {
                            Id = 9,
                            AvatarUrl = "https://swiperjs.com/demos/images/nature-9.jpg",
                            CategoryId = 1,
                            DateEnd = new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8451),
                            DateStart = new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8452),
                            DonationGoal = 500000m,
                            OrganizationFundraiseId = 9,
                            ShortTitle = "Tiltle number 9",
                            Status = "",
                            Story = "Story number 9",
                            Title = "Tiltle long number 9",
                            TotalDonate = 450000m,
                            UrlSlug = "url-9"
                        });
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.MomoUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MomoUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.DonateHistory", b =>
                {
                    b.HasOne("ProjectMomoDonation.Core.Models.MomoUser", "MomoUser")
                        .WithMany("DonateHistorys")
                        .HasForeignKey("Id");

                    b.HasOne("ProjectMomoDonation.Core.Models.ProgramDonation", "ProgramDonation")
                        .WithMany("DonateHistorys")
                        .HasForeignKey("ProgramDonationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MomoUser");

                    b.Navigation("ProgramDonation");
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.ProgramDonation", b =>
                {
                    b.HasOne("ProjectMomoDonation.Core.Models.Category", null)
                        .WithMany("ProgramDonations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectMomoDonation.Core.Models.OrganizationFundraise", "OrganizationFundraise")
                        .WithMany("ProgramDonations")
                        .HasForeignKey("OrganizationFundraiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrganizationFundraise");
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.Category", b =>
                {
                    b.Navigation("ProgramDonations");
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.OrganizationFundraise", b =>
                {
                    b.Navigation("ProgramDonations");
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.ProgramDonation", b =>
                {
                    b.Navigation("DonateHistorys");
                });

            modelBuilder.Entity("ProjectMomoDonation.Core.Models.MomoUser", b =>
                {
                    b.Navigation("DonateHistorys");
                });
#pragma warning restore 612, 618
        }
    }
}
