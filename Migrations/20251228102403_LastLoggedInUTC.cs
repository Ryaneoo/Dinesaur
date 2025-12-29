using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class LastLoggedInUTC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginAtUtc",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PreviousLoginAtUtc",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "LastLoginAtUtc", "PasswordHash", "PreviousLoginAtUtc", "SecurityStamp" },
                values: new object[] { "f013445e-fb82-4909-9c49-42b76e340012", new DateTime(2025, 12, 28, 10, 24, 2, 29, DateTimeKind.Utc).AddTicks(3940), null, "AQAAAAIAAYagAAAAEE+I/9f9wHkzYBqF7qcVb6aJBDVwuwPm/WWTHR+KC/13IddnBuym6uARFRhU2K1uDQ==", null, "04257640-b1e1-4ed4-8c5e-93ea83942c78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "LastLoginAtUtc", "PasswordHash", "PreviousLoginAtUtc", "SecurityStamp" },
                values: new object[] { "de72c689-65ac-4977-9dfe-f13b06c2dd3e", new DateTime(2025, 12, 28, 10, 24, 2, 91, DateTimeKind.Utc).AddTicks(6549), null, "AQAAAAIAAYagAAAAEGoaDRDl8qhmNvjp2LS7j9wvjMKJiXD01zItGhZ/ol84nOBDi+tZHuAtsn0rrKsK8A==", null, "30bf9d48-22bc-41f5-b3f5-8e13e60ab1d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "LastLoginAtUtc", "PasswordHash", "PreviousLoginAtUtc", "SecurityStamp" },
                values: new object[] { "785baa73-0cfe-440d-9ba9-e016e62b582a", new DateTime(2025, 12, 28, 10, 24, 2, 151, DateTimeKind.Utc).AddTicks(5389), null, "AQAAAAIAAYagAAAAEFLCmwE/QfVRrwDb6Tu/orKOpQBC62WW1InRadgl7iFYu2HcyAA3z9WM4OSsmJ6cTg==", null, "07ce8f2e-7697-42fd-9278-0574dd8e1ac2" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 24, 2, 29, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 24, 2, 29, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 24, 2, 29, DateTimeKind.Local).AddTicks(3590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLoginAtUtc",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PreviousLoginAtUtc",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ae1896-a2fb-4f5b-8e86-5e8fba0a2bd6", new DateTime(2025, 12, 28, 10, 19, 13, 901, DateTimeKind.Utc).AddTicks(309), "AQAAAAIAAYagAAAAEPGi9++ldNV9UsqUa2OrZMvhxEBEzjfmP8DDWJWWkjgrxKv5xFRnlrKjvJhkacjdUQ==", "6a518d54-1b7f-491d-91f4-ea5dbed48b02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e36d81-a72a-42ef-a436-ae719388235b", new DateTime(2025, 12, 28, 10, 19, 13, 961, DateTimeKind.Utc).AddTicks(2658), "AQAAAAIAAYagAAAAEHCvY5x5CCOwd58uuJwpAX+h/dg/TaFFWY3emMzUDDPde/3Z2zkwNTSdJdCPvZ/1EQ==", "ff95dc03-1ce7-4ed7-b6ef-38c81aa6489b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beb5c1e0-bf61-44d6-90cd-ee2faf996536", new DateTime(2025, 12, 28, 10, 19, 14, 24, DateTimeKind.Utc).AddTicks(8926), "AQAAAAIAAYagAAAAENaPZH/VWMFXQKuRKtza2VomtQw4zaCbg8h8Gl1hydl/onpjrlxy7/mm6WbYHtxmZA==", "15cb7e72-b12f-452c-b0e5-6363aa0cbe3a" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 19, 13, 900, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 19, 13, 900, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 12, 28, 18, 19, 13, 900, DateTimeKind.Local).AddTicks(9986));
        }
    }
}
