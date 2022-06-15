using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPractice.DAL.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5312ee2f-5c9b-4881-89cf-f920d2b7227d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a066a3fb-6b51-495d-8bb7-8ea4a776218b", "AQAAAAEAACcQAAAAEIixrFMAIGToq5ihqm1DPys1xqrPVXAmtkFw3OyUl+dZtmNxeNn7ES/V+O4r9QHN5w==", "3f6d9557-da93-48ce-9d33-330a9c90dc2d" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 23, 10, 36, 58, 290, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 23, 10, 36, 58, 288, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 23, 10, 36, 58, 291, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 23, 10, 36, 58, 291, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 23, 10, 36, 58, 291, DateTimeKind.Local).AddTicks(3764));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3a43c1c4-9900-4a3d-b8f8-877aeb7a0f6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22f821b-9289-4874-abb2-de84212d0e3c", "AQAAAAEAACcQAAAAECEFqvGzFFsPdWMDpgYLcghaFd6Uy13cmJlz6mmv22EOQqIPoQ4f7ZvyPAiJiEx4UQ==", "0509c24d-fe34-4bdf-9b67-ef57d6e79c66" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 328, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 326, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 329, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 329, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 329, DateTimeKind.Local).AddTicks(7037));
        }
    }
}
