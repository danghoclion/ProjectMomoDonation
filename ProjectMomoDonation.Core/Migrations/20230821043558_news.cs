using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class news : Migration
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgramDonationId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonateHistorys", x => new { x.Id, x.ProgramDonationId });
                    table.ForeignKey(
                        name: "FK_DonateHistorys_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonateHistorys_ProgramDonations_ProgramDonationId",
                        column: x => x.ProgramDonationId,
                        principalTable: "ProgramDonations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "ProgramDonations",
                columns: new[] { "Id", "AvatarUrl", "CategoryId", "DateEnd", "DateStart", "DonationGoal", "OrganizationFundraiseId", "ShortTitle", "Status", "Story", "Title", "TotalDonate", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "https://swiperjs.com/demos/images/nature-1.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(790), 500000m, 1, "Tiltle number 1", "", "Story number 1", "Tiltle long number 1", 50000m, null },
                    { 2, "https://swiperjs.com/demos/images/nature-2.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(813), 500000m, 2, "Tiltle number 2", "", "Story number 2", "Tiltle long number 2", 100000m, null },
                    { 3, "https://swiperjs.com/demos/images/nature-3.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(818), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(819), 500000m, 3, "Tiltle number 3", "", "Story number 3", "Tiltle long number 3", 150000m, null },
                    { 4, "https://swiperjs.com/demos/images/nature-4.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(823), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(824), 500000m, 4, "Tiltle number 4", "", "Story number 4", "Tiltle long number 4", 200000m, null },
                    { 5, "https://swiperjs.com/demos/images/nature-5.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(830), 500000m, 5, "Tiltle number 5", "", "Story number 5", "Tiltle long number 5", 250000m, null },
                    { 6, "https://swiperjs.com/demos/images/nature-6.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(836), 500000m, 6, "Tiltle number 6", "", "Story number 6", "Tiltle long number 6", 300000m, null },
                    { 7, "https://swiperjs.com/demos/images/nature-7.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(842), 500000m, 7, "Tiltle number 7", "", "Story number 7", "Tiltle long number 7", 350000m, null },
                    { 8, "https://swiperjs.com/demos/images/nature-8.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(848), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(848), 500000m, 8, "Tiltle number 8", "", "Story number 8", "Tiltle long number 8", 400000m, null },
                    { 9, "https://swiperjs.com/demos/images/nature-9.jpg", 1, new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(854), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(854), 500000m, 9, "Tiltle number 9", "", "Story number 9", "Tiltle long number 9", 450000m, null }
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
