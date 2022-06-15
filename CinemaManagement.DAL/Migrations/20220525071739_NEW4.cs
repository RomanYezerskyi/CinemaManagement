using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPractice.DAL.Migrations
{
    public partial class NEW4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkTrailer",
                table: "FilmImages");

            migrationBuilder.AddColumn<string>(
                name: "LinkTrailer",
                table: "Films",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6e0b21ec-444b-4eea-a3e4-cd6f6d4daee4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f38843fd-2c8c-48ba-aafe-749185ed4b13", "AQAAAAEAACcQAAAAEJWiL5elXuLIR0m/YaoDBY6pcJS3LgYD59WpTtPUBS4l83HMNwBwpCu0SsD1pk2x+Q==", "e0ae9547-397a-451c-b19c-b86e185013c8" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                column: "LinkTrailer",
                value: "https://youtu.be/JfVOs4VSpmA");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 5, 25, 10, 17, 39, 289, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 25, 10, 17, 39, 287, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 25, 10, 17, 39, 290, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 25, 10, 17, 39, 290, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 25, 10, 17, 39, 290, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(1991, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(1991, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(1991, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkTrailer",
                table: "Films");

            migrationBuilder.AddColumn<string>(
                name: "LinkTrailer",
                table: "FilmImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5dbd3bb8-4669-4678-8b4d-3da217e6630c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "userId=1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dc09db0-a82f-4338-b809-3bd60ea4d9bb", "AQAAAAEAACcQAAAAEIXHA8bHOMSkmSxqnGc/67qc0J6cw/26D6aemL8vFK+OxJQwGv+/G5SuFqLLbxMg6Q==", "42f993c5-84cb-41d8-99bc-86a5da96db4c" });

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
                keyValue: 6,
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
                value: new DateTime(2022, 5, 24, 1, 30, 59, 609, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 24, 1, 30, 59, 607, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 24, 1, 30, 59, 610, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 24, 1, 30, 59, 610, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 24, 1, 30, 59, 610, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(1991, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(1991, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(1991, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
