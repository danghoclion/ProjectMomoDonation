using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "DonateHistorys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 8, 21, 14, 46, 28, 981, DateTimeKind.Local).AddTicks(3431) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "DonateHistorys");

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(818), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(823), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(836), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(848), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(854), new DateTime(2023, 8, 21, 11, 35, 58, 361, DateTimeKind.Local).AddTicks(854) });
        }
    }
}
