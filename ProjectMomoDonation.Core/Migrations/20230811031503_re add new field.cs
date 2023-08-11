using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class readdnewfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "OrganazationFundraise",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 1,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 2,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 3,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 4,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 5,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 6,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 7,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 8,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrganazationFundraise",
                keyColumn: "OrganizationFundraiseId",
                keyValue: 9,
                column: "UrlSlug",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(334), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(347), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(350), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(352), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(353), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(355), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(359), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(362), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(365), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 9, 30, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 8, 11, 10, 15, 2, 850, DateTimeKind.Local).AddTicks(367), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "ProgramDonations");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "OrganazationFundraise");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Categories");

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
    }
}
