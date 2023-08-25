using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class newscolum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9a1c5b-28f9-42cf-a46b-b398a54d594e", "AQAAAAIAAYagAAAAEKhaOCD9fHju7DfWeR9rNJtsG8fv4mAtYWJkyd/lhgi1cj5AUQ1g516MTGtZ7KpImg==", "2aaea741-7c42-46f2-ab2a-ec673c8c742d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8F55A479-468A-480B-9AE9-6B353B2825E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e432644-a0c0-409f-b7d7-361f0abaa7a4", "AQAAAAIAAYagAAAAEBKrQyg0n2a0qZaTFaBbgtmAybNAnp70YZQV6zsAkgTaKV3vHzu59jelPPabobtzzA==", "3f85c6a7-3b59-4bba-ae49-3306b9c3f71b" });

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 25, 16, 9, 48, 874, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 25, 17, 9, 48, 874, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 8, 25, 18, 9, 48, 874, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 8, 25, 19, 9, 48, 874, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 8, 25, 20, 9, 48, 874, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 8, 25, 21, 9, 48, 874, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 8, 25, 22, 9, 48, 874, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 8, 25, 23, 9, 48, 874, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 8, 26, 0, 9, 48, 874, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 14, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 8, 25, 15, 9, 48, 737, DateTimeKind.Local).AddTicks(1582) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35e5b383-53f4-4141-8e45-4cf8fd81703d", "AQAAAAIAAYagAAAAEKO6LhqcEPhaI7vY9p5//zV4DgYeMxTSsxbv3mCrjDsbjn3CSbN/cuGPQsgi0uhbUw==", "07dc96a9-6717-47f8-a005-41cd969c3f26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8F55A479-468A-480B-9AE9-6B353B2825E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d09eca5d-69eb-4a7d-a429-dfcab937e153", "AQAAAAIAAYagAAAAELy5tckVinPuFDetypr5kN40rQDrSJKbHn6RN+VQlcm3fFZ+AmSYlwFhxcS/3Xv+Eg==", "0ae5288d-9ea4-48a7-a4d8-975be7240ccb" });

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 22, 0, 41, 30, 766, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 22, 1, 41, 30, 766, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 8, 22, 2, 41, 30, 766, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 8, 22, 3, 41, 30, 766, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 8, 22, 4, 41, 30, 766, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 8, 22, 5, 41, 30, 766, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 8, 22, 6, 41, 30, 766, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 8, 22, 7, 41, 30, 766, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 8, 22, 8, 41, 30, 766, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7581), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7671), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7671) });
        }
    }
}
