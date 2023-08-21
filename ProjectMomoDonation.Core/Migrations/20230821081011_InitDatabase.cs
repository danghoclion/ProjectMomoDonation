using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "OrganazationFundraise",
                columns: table => new
                {
                    OrganizationFundraiseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganazationFundraise", x => x.OrganizationFundraiseId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramDonations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Story = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDonate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DonationGoal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    OrganizationFundraiseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramDonations_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramDonations_OrganazationFundraise_OrganizationFundraiseId",
                        column: x => x.OrganizationFundraiseId,
                        principalTable: "OrganazationFundraise",
                        principalColumn: "OrganizationFundraiseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonateHistorys",
                columns: table => new
                {
                    HistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProgramDonationId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonateHistorys", x => x.HistoryID);
                    table.ForeignKey(
                        name: "FK_DonateHistorys_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DonateHistorys_ProgramDonations_ProgramDonationId",
                        column: x => x.ProgramDonationId,
                        principalTable: "ProgramDonations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89", "guestRoleId", "guest", "GUEST" },
                    { "378b471d-756a-46c2-973b-159f2e64bdac", "adminRoleId", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 0, "f411547a-9019-4d5e-9f51-d23d0b622996", "IdentityUser", "guest@gmail.com", true, false, null, "GUEST@GMAIL.COM", "GUEST@GMAIL.COM", "AQAAAAIAAYagAAAAEClTfXayRjZN7NRl6WLsMM3W4GTDI7Dw7p9+uFxsRWvO0zJz/fFZJfVU1sCCmTzNaA==", null, false, "25a3084d-113c-4604-8d55-248b90566236", false, "guest@gmail.com" },
                    { "8F55A479-468A-480B-9AE9-6B353B2825E0", 0, "e7dc5d13-7801-4459-bc35-54953e988338", "IdentityUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJnZhT7jX9PXQIbXfN5bZ2eMbCnWNsZmX7E9WXqZ7FsCZlRese3ZhhvMx/ZVTQUayw==", null, false, "4d04ebde-3182-4b66-bdc1-cf30287ee90d", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "Description + 1", "Name +1", null },
                    { 2, "Description + 2", "Name +2", null },
                    { 3, "Description + 3", "Name +3", null },
                    { 4, "Description + 4", "Name +4", null },
                    { 5, "Description + 5", "Name +5", null },
                    { 6, "Description + 6", "Name +6", null },
                    { 7, "Description + 7", "Name +7", null },
                    { 8, "Description + 8", "Name +8", null },
                    { 9, "Description + 9", "Name +9", null }
                });

            migrationBuilder.InsertData(
                table: "OrganazationFundraise",
                columns: new[] { "OrganizationFundraiseId", "Avatar", "Description", "Image", "Name", "ShortName", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "https://swiperjs.com/demos/images/nature-1.jpg", "Description + 1", "Image +1", "Name +1", "Short name +1", null },
                    { 2, "https://swiperjs.com/demos/images/nature-2.jpg", "Description + 2", "Image +2", "Name +2", "Short name +2", null },
                    { 3, "https://swiperjs.com/demos/images/nature-3.jpg", "Description + 3", "Image +3", "Name +3", "Short name +3", null },
                    { 4, "https://swiperjs.com/demos/images/nature-4.jpg", "Description + 4", "Image +4", "Name +4", "Short name +4", null },
                    { 5, "https://swiperjs.com/demos/images/nature-5.jpg", "Description + 5", "Image +5", "Name +5", "Short name +5", null },
                    { 6, "https://swiperjs.com/demos/images/nature-6.jpg", "Description + 6", "Image +6", "Name +6", "Short name +6", null },
                    { 7, "https://swiperjs.com/demos/images/nature-7.jpg", "Description + 7", "Image +7", "Name +7", "Short name +7", null },
                    { 8, "https://swiperjs.com/demos/images/nature-8.jpg", "Description + 8", "Image +8", "Name +8", "Short name +8", null },
                    { 9, "https://swiperjs.com/demos/images/nature-9.jpg", "Description + 9", "Image +9", "Name +9", "Short name +9", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89", "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A" },
                    { "378b471d-756a-46c2-973b-159f2e64bdac", "8F55A479-468A-480B-9AE9-6B353B2825E0" }
                });

            migrationBuilder.InsertData(
                table: "ProgramDonations",
                columns: new[] { "Id", "AvatarUrl", "CategoryId", "DateEnd", "DateStart", "DonationGoal", "OrganizationFundraiseId", "ShortTitle", "Status", "Story", "Title", "TotalDonate", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "https://swiperjs.com/demos/images/nature-1.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7945), 500000m, 1, "Tiltle number 1", "", "Story number 1", "Tiltle long number 1", 50000m, null },
                    { 2, "https://swiperjs.com/demos/images/nature-2.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7965), 500000m, 2, "Tiltle number 2", "", "Story number 2", "Tiltle long number 2", 100000m, null },
                    { 3, "https://swiperjs.com/demos/images/nature-3.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8034), 500000m, 3, "Tiltle number 3", "", "Story number 3", "Tiltle long number 3", 150000m, null },
                    { 4, "https://swiperjs.com/demos/images/nature-4.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8040), 500000m, 4, "Tiltle number 4", "", "Story number 4", "Tiltle long number 4", 200000m, null },
                    { 5, "https://swiperjs.com/demos/images/nature-5.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8045), 500000m, 5, "Tiltle number 5", "", "Story number 5", "Tiltle long number 5", 250000m, null },
                    { 6, "https://swiperjs.com/demos/images/nature-6.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8054), 500000m, 6, "Tiltle number 6", "", "Story number 6", "Tiltle long number 6", 300000m, null },
                    { 7, "https://swiperjs.com/demos/images/nature-7.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8059), 500000m, 7, "Tiltle number 7", "", "Story number 7", "Tiltle long number 7", 350000m, null },
                    { 8, "https://swiperjs.com/demos/images/nature-8.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8066), 500000m, 8, "Tiltle number 8", "", "Story number 8", "Tiltle long number 8", 400000m, null },
                    { 9, "https://swiperjs.com/demos/images/nature-9.jpg", 1, new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8072), 500000m, 9, "Tiltle number 9", "", "Story number 9", "Tiltle long number 9", 450000m, null }
                });

            migrationBuilder.InsertData(
                table: "DonateHistorys",
                columns: new[] { "HistoryID", "Amount", "Id", "ProgramDonationId", "Time" },
                values: new object[,]
                {
                    { 1, 200000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 1, new DateTime(2023, 8, 21, 16, 10, 10, 703, DateTimeKind.Local).AddTicks(8730) },
                    { 2, 400000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 2, new DateTime(2023, 8, 21, 17, 10, 10, 703, DateTimeKind.Local).AddTicks(8762) },
                    { 3, 600000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 3, new DateTime(2023, 8, 21, 18, 10, 10, 703, DateTimeKind.Local).AddTicks(8764) },
                    { 4, 800000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 4, new DateTime(2023, 8, 21, 19, 10, 10, 703, DateTimeKind.Local).AddTicks(8765) },
                    { 5, 1000000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 5, new DateTime(2023, 8, 21, 20, 10, 10, 703, DateTimeKind.Local).AddTicks(8767) },
                    { 6, 1200000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 6, new DateTime(2023, 8, 21, 21, 10, 10, 703, DateTimeKind.Local).AddTicks(8780) },
                    { 7, 1400000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 7, new DateTime(2023, 8, 21, 22, 10, 10, 703, DateTimeKind.Local).AddTicks(8781) },
                    { 8, 1600000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 8, new DateTime(2023, 8, 21, 23, 10, 10, 703, DateTimeKind.Local).AddTicks(8782) },
                    { 9, 1800000m, "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A", 9, new DateTime(2023, 8, 22, 0, 10, 10, 703, DateTimeKind.Local).AddTicks(8783) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DonateHistorys_Id",
                table: "DonateHistorys",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DonateHistorys_ProgramDonationId",
                table: "DonateHistorys",
                column: "ProgramDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDonations_CategoryId",
                table: "ProgramDonations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramDonations_OrganizationFundraiseId",
                table: "ProgramDonations",
                column: "OrganizationFundraiseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DonateHistorys");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProgramDonations");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "OrganazationFundraise");
        }
    }
}
