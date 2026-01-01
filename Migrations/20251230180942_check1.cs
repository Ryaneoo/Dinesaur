using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class check1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Reservation",
                newName: "StartDate");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Pax",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CustomerID", "EndDate", "Pax", "Remarks", "StartDate" },
                values: new object[] { 1, new DateTime(2025, 12, 31, 4, 9, 41, 264, DateTimeKind.Local).AddTicks(832), 0, null, new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "CustomerID", "EndDate", "Pax", "StartDate" },
                values: new object[] { 1, new DateTime(2025, 12, 31, 4, 9, 41, 264, DateTimeKind.Local).AddTicks(840), 0, new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 31, 2, 9, 41, 264, DateTimeKind.Local).AddTicks(1015));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Pax",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Reservation",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Reservation",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "343dcc22-d30a-4fab-b0c0-30fe4587a868", new DateTime(2025, 12, 30, 16, 23, 27, 591, DateTimeKind.Utc).AddTicks(7457), "AQAAAAIAAYagAAAAEPkqiGwQ38e7Mu2FjIxlCO/Wosjh77v66L/pP09Ov5igWw1SzWT1qFRgIVqGmty9cQ==", "b50466e4-a27e-4047-88a0-9b773ed63e05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a995310b-138b-4df5-a104-23824041052a", new DateTime(2025, 12, 30, 16, 23, 27, 650, DateTimeKind.Utc).AddTicks(5977), "AQAAAAIAAYagAAAAEG+cn6kV5TA7nncXaGmZ5d0EbnvWgp7RA5n74pgmo3weQHeKim1EvKXJHpFWaz3qOg==", "facbaa16-cc07-4484-b63d-a083ee10a9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb43c2c-a179-4ed8-b6b2-48f6fffa6d40", new DateTime(2025, 12, 30, 16, 23, 27, 710, DateTimeKind.Utc).AddTicks(6743), "AQAAAAIAAYagAAAAEHRuw+leCxCWZY68rrsZKO9eSVlZIrD/xR/C13VH4YEPyamxkJEPweODYr5usW626A==", "12dd58a2-7c3f-48e9-9ba3-e9bfd64db0af" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "Date", "Location", "Remarks", "Time" },
                values: new object[] { new DateTime(2025, 12, 31, 0, 23, 27, 591, DateTimeKind.Local).AddTicks(7112), "Orchard", "Null", new TimeSpan(14075917109) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "Date", "Location", "Time" },
                values: new object[] { new DateTime(2025, 12, 31, 0, 23, 27, 591, DateTimeKind.Local).AddTicks(7115), "Novena", new TimeSpan(14075917114) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 31, 0, 23, 27, 591, DateTimeKind.Local).AddTicks(7275));
        }
    }
}
