using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class newfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 1,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-1.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 2,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-2.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 3,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-3.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 4,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-4.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 5,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-5.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 6,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-6.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 7,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-7.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 8,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-8.jpg");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 9,
                column: "Avatar",
                value: "https://swiperjs.com/demos/images/nature-9.jpg");

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(726), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(731), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(750), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(755), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(761), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(766), new DateTime(2023, 8, 11, 10, 2, 15, 440, DateTimeKind.Local).AddTicks(767) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 1,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 2,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 3,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 4,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 5,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 6,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 7,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 8,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 9,
                column: "Avatar",
                value: "");

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8454), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8495), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8522), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 9, 29, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8533), new DateTime(2023, 8, 10, 10, 8, 57, 373, DateTimeKind.Local).AddTicks(8534) });
        }
    }
}
