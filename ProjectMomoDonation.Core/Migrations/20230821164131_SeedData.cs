using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMomoDonation.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7581), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7601), "url-1" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7620), "url-2" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7628), "url-3" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7635), "url-4" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7642), "url-5" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7650), "url-6" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7657), "url-7" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7664), "url-8" });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7671), new DateTime(2023, 8, 21, 23, 41, 30, 503, DateTimeKind.Local).AddTicks(7671), "url-9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6D7D3D3E-6E4D-4CD3-951B-2AE1DF03698A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f411547a-9019-4d5e-9f51-d23d0b622996", "AQAAAAIAAYagAAAAEClTfXayRjZN7NRl6WLsMM3W4GTDI7Dw7p9+uFxsRWvO0zJz/fFZJfVU1sCCmTzNaA==", "25a3084d-113c-4604-8d55-248b90566236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8F55A479-468A-480B-9AE9-6B353B2825E0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7dc5d13-7801-4459-bc35-54953e988338", "AQAAAAIAAYagAAAAEJnZhT7jX9PXQIbXfN5bZ2eMbCnWNsZmX7E9WXqZ7FsCZlRese3ZhhvMx/ZVTQUayw==", "4d04ebde-3182-4b66-bdc1-cf30287ee90d" });

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 21, 16, 10, 10, 703, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 21, 17, 10, 10, 703, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2023, 8, 21, 18, 10, 10, 703, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2023, 8, 21, 19, 10, 10, 703, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2023, 8, 21, 20, 10, 10, 703, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2023, 8, 21, 21, 10, 10, 703, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2023, 8, 21, 22, 10, 10, 703, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 8,
                column: "Time",
                value: new DateTime(2023, 8, 21, 23, 10, 10, 703, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "DonateHistorys",
                keyColumn: "HistoryID",
                keyValue: 9,
                column: "Time",
                value: new DateTime(2023, 8, 22, 0, 10, 10, 703, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7945), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(7965), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8034), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8040), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8045), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8054), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8059), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8066), null });

            migrationBuilder.UpdateData(
                table: "ProgramDonations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateEnd", "DateStart", "UrlSlug" },
                values: new object[] { new DateTime(2023, 10, 10, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 8, 21, 15, 10, 10, 429, DateTimeKind.Local).AddTicks(8072), null });
        }
    }
}
