using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewsApprovalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Date", "Status" },
                values: new object[] { new DateTime(2026, 1, 1, 22, 47, 38, 28, DateTimeKind.Local).AddTicks(4447), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a760467-bb6b-4732-b592-62d44faf4522", new DateTime(2026, 1, 1, 14, 37, 51, 301, DateTimeKind.Utc).AddTicks(1388), "AQAAAAIAAYagAAAAEIjRKjc7Orq7+zn5RJR18QtJGRUlf+y8LLV2Kir+Dj+Xw5ThS1ouh0SVB628zA2uCg==", "816910ab-eed1-4806-be34-b988ee070d9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7bf47dc-5b2d-4f6a-b38a-061b57ab62ad", new DateTime(2026, 1, 1, 14, 37, 51, 357, DateTimeKind.Utc).AddTicks(9850), "AQAAAAIAAYagAAAAEFNqSSN4esb3PpCiLa+zQAwzBW6vkRF2m/8AH/LtIHaVfYRM7bZdyjvfbLj2P1sS9g==", "948d62d1-9e2e-476f-ac28-4bfbbfd85336" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3d708da-e20c-4be2-9142-6155859ae15b", new DateTime(2026, 1, 1, 14, 37, 51, 414, DateTimeKind.Utc).AddTicks(1800), "AQAAAAIAAYagAAAAEELMjzLcq+EWWSpGhj0LuVwUUJ1E/qXU1IfGJuINzzODa1i67CTJgoPUMXjH7X7MEQ==", "c941901c-2879-4f01-b5fe-60c1905a5bdf" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 37, 51, 301, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 37, 51, 301, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 37, 51, 301, DateTimeKind.Local).AddTicks(1141));
        }
    }
}
