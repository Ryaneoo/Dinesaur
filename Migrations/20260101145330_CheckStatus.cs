using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class CheckStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb726a4e-c2ce-4977-aae4-f10bb7c2bf65", new DateTime(2026, 1, 1, 14, 53, 29, 674, DateTimeKind.Utc).AddTicks(2818), "AQAAAAIAAYagAAAAEK+z6vQU9eIN9xfJ/8/6w5npkRT+7ypgNEw2cbNLhwNW7adig0+TPdlhr6drk9swPw==", "b5d8966f-0b7a-4952-8669-177e0e5a4658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d29d569-e143-42a6-80d2-cd3e3c3c4a60", new DateTime(2026, 1, 1, 14, 53, 29, 731, DateTimeKind.Utc).AddTicks(6431), "AQAAAAIAAYagAAAAELrYwyUHRjeQKeM/o1tII0yOBgYbXcGxoKy/LuMayDN2h+26hRiEEtW50uOWFK7B+g==", "55eddb57-b650-48a7-a61b-27509df19bff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca51db04-24c5-4fe2-870e-ca87685edfa9", new DateTime(2026, 1, 1, 14, 53, 29, 792, DateTimeKind.Utc).AddTicks(8262), "AQAAAAIAAYagAAAAEI3LSfQDFOFgMefX2yywXYMjErX1flkG6gHfZ9sOrSiO64ERwP3x/sqotRW5FLAPvA==", "b7d1f268-94ce-4688-a6d0-15619c7e79b3" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2532));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e9fd5f3-a51e-4f96-b160-dbc986898c7c", new DateTime(2026, 1, 1, 14, 47, 38, 28, DateTimeKind.Utc).AddTicks(4694), "AQAAAAIAAYagAAAAENYt5qc8D3mDa8eIfGQ3Cem12afJbZru00ErNEUkoujGbu5PmxvsjpGN2JBZJFKjMw==", "8c1aa1b8-5342-4967-8c6f-53ec7b19a256" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2ebcc8-ce59-467d-9b5a-be2c925b0a1b", new DateTime(2026, 1, 1, 14, 47, 38, 81, DateTimeKind.Utc).AddTicks(4187), "AQAAAAIAAYagAAAAEA7ZNinmEacRXLMCAResZoQMQ5CtwvQi1z08zEAhym/9Njkml8Jv1Q6s2VLIcvURgA==", "7b7c4363-cab7-4e38-b215-318105e6a46c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e9bec7-72ab-48cc-969e-c9b548e9ca0e", new DateTime(2026, 1, 1, 14, 47, 38, 136, DateTimeKind.Utc).AddTicks(1305), "AQAAAAIAAYagAAAAEOesjsZR2Sm8Pt1wYTTfqvcNP+j1m4h1dsYlyNKd4kEVIEnKvF1XxbWhXhASUCYTCw==", "aa7b0a84-6fe8-4b29-909c-e354a6aea76d" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 47, 38, 28, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 47, 38, 28, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 47, 38, 28, DateTimeKind.Local).AddTicks(4447));
        }
    }
}
