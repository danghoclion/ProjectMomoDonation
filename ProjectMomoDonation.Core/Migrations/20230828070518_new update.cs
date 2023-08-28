using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class newupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Story",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15557381-23ce-47b4-aff1-c13345d02f79", "AQAAAAIAAYagAAAAEHXhgcm8anC6kBcEDGwj2j6vO0owXTEqD5jfP3gJXnFPxctNZwufJAOhqJUb8CR6Vw==", "965b5693-4683-453c-a78e-3db6a10e9322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8F55A479-468A-480B-9AE9-6B353B2825E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e1d80b8-ab19-4972-a2b9-4198771042e0", "AQAAAAIAAYagAAAAEEfTnWujD8DG1y1Pr14pmMT6lsSImtMMFVfwwzqMRF8YxQSNDRLrBudl/SilUzx6Ag==", "f2f22ea9-4711-4cbe-9419-019e0152b033" });

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 28, 15, 5, 18, 182, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 28, 16, 5, 18, 182, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 8, 28, 17, 5, 18, 182, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 8, 28, 18, 5, 18, 182, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 8, 28, 19, 5, 18, 182, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 8, 28, 20, 5, 18, 182, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 8, 28, 21, 5, 18, 182, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 8, 28, 22, 5, 18, 182, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 8, 28, 23, 5, 18, 182, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8420), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8431), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8441), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2023, 10, 17, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 8, 28, 14, 5, 18, 4, DateTimeKind.Local).AddTicks(8452) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Story",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "ProgramDonations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
