using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class neeMenuDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "Menu",
                newName: "RestaurantID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "172de701-01ad-458e-922c-37d0035a0062", new DateTime(2026, 1, 2, 11, 4, 16, 184, DateTimeKind.Utc).AddTicks(1591), "AQAAAAIAAYagAAAAEBGOr666qdhQd2CUhYE251Dai4dT/QjhrzP5ETKmgNlx1pPOXFTxtbL/tGaMjJXpvQ==", "60d6752d-0feb-4ac8-9b13-9ac2cac3a60d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0367fe7a-fe2b-4202-93dc-3e7244c2e678", new DateTime(2026, 1, 2, 11, 4, 16, 241, DateTimeKind.Utc).AddTicks(6378), "AQAAAAIAAYagAAAAEMMjQILotJwCl3X4n4HF5PrWuiQbwhsUd/s1iW2drJi0sKYep12JdYK9W00iXWgTHA==", "b8b0f5c4-8e30-4ab2-9bed-dcd15d12bd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "695ead55-c08b-456d-84d4-8b8306a830b7", new DateTime(2026, 1, 2, 11, 4, 16, 314, DateTimeKind.Utc).AddTicks(809), "AQAAAAIAAYagAAAAEPlIAzwYgjDUQ9WWBEkkmYSHWPgdgCAuHZ6Vuy4HiqZB3lH7JYL4HEpEl5xDUMzmFA==", "70a850d6-1623-48d2-8717-8f438fc7b01b" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2026, 1, 2, 21, 4, 16, 184, DateTimeKind.Local).AddTicks(1246), new DateTime(2026, 1, 2, 19, 4, 16, 184, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                column: "EndDate",
                value: new DateTime(2026, 1, 2, 21, 4, 16, 184, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 2, 19, 4, 16, 184, DateTimeKind.Local).AddTicks(1419));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Menu",
                newName: "ReservationID");

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Menu",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Menu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "178449d0-4b9e-436f-a084-a22e45c12be2", new DateTime(2026, 1, 2, 10, 1, 13, 933, DateTimeKind.Utc).AddTicks(6803), "AQAAAAIAAYagAAAAEPuhzwML6Pb6i1YEE+EFz7Dazig03vwSMAvCJR8ZOV1mOtxOTFu1XgV1sF1fqgFOIg==", "8b13118b-e719-40b3-aaf7-d828679fd28f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d3d3ce0-cb11-4eb6-8746-037abe1c4534", new DateTime(2026, 1, 2, 10, 1, 14, 6, DateTimeKind.Utc).AddTicks(9912), "AQAAAAIAAYagAAAAEHE7KjuDx9nzV9HOY9ZeBAUsqoLLN3XChrj8tuRAbUt9hsOHlTlP7xydvdi4jJ/ssA==", "b2e6baca-ef55-47f9-8818-5c87e2496f48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6119236-e2df-4ff4-9b6d-26ff619a7025", new DateTime(2026, 1, 2, 10, 1, 14, 82, DateTimeKind.Utc).AddTicks(7527), "AQAAAAIAAYagAAAAEHLGO39/Ee3J+iX3az727qCd7KYi2jW6+JjedoWV1R1zO0lpLNoKXlXJyNv4Jg43Tg==", "2f3307aa-e7bd-43a2-b016-56ca5be8be46" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "Cost", "FoodID" },
                values: new object[] { 3.5, 1 });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "Cost", "FoodID" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2026, 1, 2, 20, 1, 13, 933, DateTimeKind.Local).AddTicks(6301), new DateTime(2026, 1, 2, 18, 1, 13, 933, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                column: "EndDate",
                value: new DateTime(2026, 1, 2, 20, 1, 13, 933, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 2, 18, 1, 13, 933, DateTimeKind.Local).AddTicks(6559));
        }
    }
}
