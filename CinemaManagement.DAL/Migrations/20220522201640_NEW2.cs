using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPractice.DAL.Migrations
{
    public partial class NEW2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 22, 23, 16, 40, 328, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 200);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Seats");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3c516a81-8242-4b41-9f4b-0ed1599487e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e99a69d-9714-45d3-9612-ec1e0e070034", "AQAAAAEAACcQAAAAEG8cHcQDclHZsaTB+smZPgNU+lBDI19slHt2JSXrph737I2eRfoRLC8N98xJyh4FmA==", "3d4e0e2f-74de-45a2-8a3b-adbf0589bf6d" });

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 22, 23, 13, 6, 323, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 13, 6, 321, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 13, 6, 324, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 13, 6, 324, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 13, 6, 324, DateTimeKind.Local).AddTicks(3792));
        }
    }
}
