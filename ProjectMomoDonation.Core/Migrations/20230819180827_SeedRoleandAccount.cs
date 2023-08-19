using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleandAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89", "guestRoleId", "guest", "GUEST" },
                    { "378b471d-756a-46c2-973b-159f2e64bdac", "adminRoleId", "admin", "ADMIN" },
                    { "c77bd53f-97dd-4a06-bc13-ece2df6f5488", "contributorRoleId", "contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "862dd4d5-21e5-4d83-821a-0685332d9aeb", 0, "c3aaefb7-214a-4475-bf93-f987afd8e381", "IdentityUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBzFsDbnOqvDpdDr/wf60w3O4/KiJaWBh/QtFNDLzWxK/JG7M6pg4KpMNYunUBGLVw==", null, false, "3c0a8639-d944-4a39-9524-ea6c23e0c794", false, "admin@gmail.com" },
                    { "886bebd4-edd6-4d6f-9b70-8190c2b8985c", 0, "661a4dbc-3be1-4078-ba93-c7eb6ccf53f7", "IdentityUser", "guest@gmail.com", true, false, null, "GUEST@GMAIL.COM", "GUEST@GMAIL.COM", "AQAAAAIAAYagAAAAEF5PT+OnTkyKWYc1lqKQuIrhN0qrTjUMhi7xiRyReeJgfItgp7ViVStSeJp8QbKeJA==", null, false, "7cfc13b3-fa42-4f34-b0e8-cdf92934b3a4", false, "guest@gmail.com" },
                    { "eef6045e-a3c2-47d3-a1df-a90cbccc9a3a", 0, "cd8e09e9-e245-4e77-8290-0fd19e831527", "IdentityUser", "contributor@gmail.com", true, false, null, "CONTRIBUTOR@GMAIL.COM", "CONTRIBUTOR@GMAIL.COM", "AQAAAAIAAYagAAAAEO9Sph+4TAFSygWUQZg3r313JwqLwfqwZfWKa5KQxnNjF9uUeybq9jGFBDypJgWcfw==", null, false, "8fc871ee-6add-4c71-a67e-f6d1b66644e8", false, "contributor@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6869), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6877), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6900), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 9, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6914), new DateTime(2023, 8, 20, 1, 8, 26, 916, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "378b471d-756a-46c2-973b-159f2e64bdac", "862dd4d5-21e5-4d83-821a-0685332d9aeb" },
                    { "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89", "886bebd4-edd6-4d6f-9b70-8190c2b8985c" },
                    { "c77bd53f-97dd-4a06-bc13-ece2df6f5488", "eef6045e-a3c2-47d3-a1df-a90cbccc9a3a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "378b471d-756a-46c2-973b-159f2e64bdac", "862dd4d5-21e5-4d83-821a-0685332d9aeb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89", "886bebd4-edd6-4d6f-9b70-8190c2b8985c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c77bd53f-97dd-4a06-bc13-ece2df6f5488", "eef6045e-a3c2-47d3-a1df-a90cbccc9a3a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ccb9777-03ff-4e1c-b22d-f7198b2e4e89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "378b471d-756a-46c2-973b-159f2e64bdac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c77bd53f-97dd-4a06-bc13-ece2df6f5488");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "862dd4d5-21e5-4d83-821a-0685332d9aeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "886bebd4-edd6-4d6f-9b70-8190c2b8985c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eef6045e-a3c2-47d3-a1df-a90cbccc9a3a");

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(352), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(367) });
        }
    }
}
