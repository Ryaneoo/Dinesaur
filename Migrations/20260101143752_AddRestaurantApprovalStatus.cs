using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantApprovalStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 37, 51, 301, DateTimeKind.Local).AddTicks(1141));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61d06ced-2000-4518-af2d-92eece1538e0", new DateTime(2025, 12, 31, 12, 55, 23, 473, DateTimeKind.Utc).AddTicks(2948), "AQAAAAIAAYagAAAAEI0xVi7RcqvmxqbbN68fW3Ef94RRH51VujfFUvZxWv7ubKgMSZ6bN6bYrAavqxaFKQ==", "a0d6b238-9756-4372-9858-d765743b321f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b22ce8-1ed7-4b3d-8c70-d2206e553eeb", new DateTime(2025, 12, 31, 12, 55, 23, 516, DateTimeKind.Utc).AddTicks(6577), "AQAAAAIAAYagAAAAECrqQDlbCJbB8A5U6MFpuVwxfCISp2niRIZqTUdHYhJnFrA3Ou0cApvZ2XpC9SFOvQ==", "dc4e3179-6258-4ed9-846b-e42412c47279" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a8392b-8248-499a-a09f-2295eb389473", new DateTime(2025, 12, 31, 12, 55, 23, 555, DateTimeKind.Utc).AddTicks(9788), "AQAAAAIAAYagAAAAELsEXuJqzKE6ksxCB/YFORANvIpt8dlR2fjf4wuSctaaeUj8xq9WhEZwqLMn4l2gGQ==", "7e757830-699a-49b0-b9ec-f9ecd93c7a94" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 31, 20, 55, 23, 473, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 12, 31, 20, 55, 23, 473, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 31, 20, 55, 23, 473, DateTimeKind.Local).AddTicks(2806));
        }
    }
}
