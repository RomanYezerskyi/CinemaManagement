using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPractice.DAL.Migrations
{
    public partial class NEW7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "583d528e-12da-4ba1-bd22-5b334f58adf3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "002755d3-9c22-4d9a-9f9c-cbb82fb0c3b4", "AQAAAAEAACcQAAAAEGtcim1NaTjSgeYB73VgGnoOUxvQdDvjhkV/YdExcvR9mKsFHh216Uf99aGWBfAUVw==", "73ddb575-b5d9-4212-bfe0-b44b91455b88" });

            migrationBuilder.InsertData(
                table: "BookedSeats",
                columns: new[] { "Id", "ReservationId", "SeatId" },
                values: new object[] { 2, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 26, 12, 41, 45, 643, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 26, 12, 41, 45, 641, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 26, 12, 41, 45, 643, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 26, 12, 41, 45, 643, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 26, 12, 41, 45, 643, DateTimeKind.Local).AddTicks(5294));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookedSeats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "82a38251-eecc-43c1-ad22-a52a7a145f4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05511ac8-228a-43f0-acf7-3b31d47cc0a1", "AQAAAAEAACcQAAAAELQOu0gIds4M2YW3eoGmN0U/P/nZeCuXF+jfnc/umlLk29RMJ4l7AGTNxS0glA4Msw==", "fd84a154-193e-4bb2-923b-200f95fc7b4c" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 26, 11, 29, 21, 471, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 26, 11, 29, 21, 468, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 26, 11, 29, 21, 471, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 26, 11, 29, 21, 471, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 26, 11, 29, 21, 471, DateTimeKind.Local).AddTicks(9963));
        }
    }
}
