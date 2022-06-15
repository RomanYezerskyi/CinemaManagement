using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPractice.DAL.Migrations
{
    public partial class NEW1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 1,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8e65161d-7c8a-4998-b920-109b773b347c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4268858e-c053-4179-9853-a80379602361", "AQAAAAEAACcQAAAAEBsCnP7hVMUU1wF7FJb/XPF+JaHjJs1t0V8d2S4+pJqxpdzEBoV7fQKFpxHvMplJ5g==", "e10f3249-fa5b-4a95-b770-ad04dfe2fdf9" });

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "FilmImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "LinkTrailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 22, 23, 1, 56, 738, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 1, 56, 735, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 1, 56, 738, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 1, 56, 738, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 22, 23, 1, 56, 738, DateTimeKind.Local).AddTicks(6031));
        }
    }
}
