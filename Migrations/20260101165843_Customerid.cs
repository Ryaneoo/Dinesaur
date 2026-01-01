using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class Customerid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c863616c-748c-4406-a06a-b64986b14066", new DateTime(2026, 1, 1, 16, 58, 41, 631, DateTimeKind.Utc).AddTicks(1267), "AQAAAAIAAYagAAAAEF4C7w/2THB8HFCRMNY8ESmqBUoHUO/qxlImxinwLkgyd0fV9wkXyGhaVN63qq+8wg==", "a4c151e1-5175-4190-b0f4-6c12ceeca479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fd98ee-aa33-4294-a543-3bb8be3400ac", new DateTime(2026, 1, 1, 16, 58, 41, 692, DateTimeKind.Utc).AddTicks(598), "AQAAAAIAAYagAAAAEAbNWG7vVT/GTQN7PJO+QtPyh8lCwciKwr8SlJkAizfQwk/H+RQvDaT6sk48oXz+7A==", "1add1c19-01d3-4ae5-833e-21cd83e9d8e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eedb95af-85d5-42bd-89e0-ca7589287915", new DateTime(2026, 1, 1, 16, 58, 41, 788, DateTimeKind.Utc).AddTicks(7213), "AQAAAAIAAYagAAAAEODT9Kge6CkUy6Xs6eUp1hxHb3AyiCcgh6qEgk0DUfj+GZ74XBXMln4Juos5wNXE4A==", "dbeb48a6-6aa9-4a48-819e-8134d25c961a" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EndDate", "StartDate" },
                values: new object[] { "1", new DateTime(2026, 1, 2, 2, 58, 41, 631, DateTimeKind.Local).AddTicks(924), new DateTime(2026, 1, 2, 0, 58, 41, 631, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EndDate", "StartDate" },
                values: new object[] { "1", new DateTime(2026, 1, 2, 2, 58, 41, 631, DateTimeKind.Local).AddTicks(929), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 2, 0, 58, 41, 631, DateTimeKind.Local).AddTicks(1100));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Reservation",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814e8201-3c91-4ca5-8231-b3f63b73d4f4", new DateTime(2025, 12, 30, 18, 9, 41, 264, DateTimeKind.Utc).AddTicks(1208), "AQAAAAIAAYagAAAAEOtuAjcBdnQDDl2fNGIY7z2oZdqhzL1PgZB87trP7GYBEYmWBtb4ezJ77xpqHBUkqg==", "1d1e25fa-de7f-466c-9090-8f49902f8fef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dc950a9-49c8-4cb0-a52f-4a7bf80d29e9", new DateTime(2025, 12, 30, 18, 9, 41, 319, DateTimeKind.Utc).AddTicks(3471), "AQAAAAIAAYagAAAAENZteI0/r/bhMxe+pjqGaQakmWa+8sc7DqsEMO8kqWbJfaQjAChoz0y9Dy9ncubvsg==", "09e72694-f50a-48aa-bf32-7350c7bef225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "053be227-e36b-43db-9fe2-a19c97c732f3", new DateTime(2025, 12, 30, 18, 9, 41, 378, DateTimeKind.Utc).AddTicks(817), "AQAAAAIAAYagAAAAELN1mHdv4yPItITNI5/JRikXcNrEl/kfqjrn374BuUFRdbKFfFwJalp/aQ2L4pqlug==", "920b2098-c195-4b90-aa64-41bf517578d0" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "CustomerID", "EndDate", "StartDate" },
                values: new object[] { 1, new DateTime(2025, 12, 31, 4, 9, 41, 264, DateTimeKind.Local).AddTicks(832), new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EndDate", "StartDate" },
                values: new object[] { 1, new DateTime(2025, 12, 31, 4, 9, 41, 264, DateTimeKind.Local).AddTicks(840), new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(1015));
        }
    }
}
