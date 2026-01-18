using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class tomahawl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f35a9751-a1b4-475e-8fbd-66c28031b07b", new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(9241), "AQAAAAIAAYagAAAAENjOiSsnHZ+264fWizsMq7yXJ/p3b5ZdkluLvzPy5QHidJ7mYPjIX0gKWWdCxNsRdA==", "1ff7f460-479c-41ea-9054-c05b967e54d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181ead17-b035-4076-aadd-57593849cf7b", new DateTime(2026, 1, 18, 6, 51, 28, 949, DateTimeKind.Utc).AddTicks(4771), "AQAAAAIAAYagAAAAENvqINl7BMF8bOGKp2cShtdSn2p0XiWvfYUkbxMi0mdHW2Bz+NU7G+F6irCaDF2ALQ==", "b2c206e0-22b4-4a32-aad1-4a3a6d23f882" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6f19afdf-31a1-4475-a74d-e232412f26d9", 82613992, new DateTime(2026, 1, 18, 6, 51, 29, 9, DateTimeKind.Utc).AddTicks(3579), "Tomahawk@gmail.com", "Tomahawk Admin", "TOMAHAWK@GMAIL.COM", "TOMAHAWK@GMAIL.COM", "AQAAAAIAAYagAAAAEAYhHE7isl94Ev0EqYMTEsZB2wTYm548+Yfyz8oLFbGB62qFBzs0PrkTw5hCxkOYvA==", "c63d7b32-e068-4003-b78d-6407e4963702", "Tomahawk@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58fbbc99-c850-457e-aed1-7a60ea6941e1", new DateTime(2026, 1, 18, 6, 51, 29, 69, DateTimeKind.Utc).AddTicks(1386), "AQAAAAIAAYagAAAAEHTgRiimcPDJy8MZclcqzSnLJqWHQrtOIEvGV6j+6GzkJeEnxojeXMJ88IHYMov5yg==", "4db391e9-56ac-4dc2-8de8-f17e9c3aada7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eb93b53-bd77-4110-a06b-894fab644c73", new DateTime(2026, 1, 18, 6, 51, 29, 126, DateTimeKind.Utc).AddTicks(833), "AQAAAAIAAYagAAAAENOCl5W0ZETcPXZsMsHzOr8Uvmf6ObEXP6IyKkGZ2otmMyceJRM1VF6vfTUaVenL/A==", "6fe313e2-7091-4cab-b5fd-1d325d497132" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97f97cf4-26ea-4df8-8a01-1ceae6ae2b70", new DateTime(2026, 1, 18, 6, 51, 29, 185, DateTimeKind.Utc).AddTicks(4163), "AQAAAAIAAYagAAAAEIdpQqf8X37IWeNF+AE4KRubrK+KcFkrlhW5G/hRBx8Z0+UomEempzxVztLp1pFJZA==", "b5af402c-b158-4e14-abb6-9033a291bd59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd99105c-487a-4bb8-b1f1-d96ac0d69592", new DateTime(2026, 1, 18, 6, 51, 29, 252, DateTimeKind.Utc).AddTicks(2780), "AQAAAAIAAYagAAAAEOg1Tu+RETYip8ICo2XRf586Ubq4Jo5A68Ak3ZuAX60+HZ2MuyE9lDChUB8/yL+bDg==", "4bb6f13f-e8bf-42f9-b7e0-d36fea1cbde4" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 51, 28, 888, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 14, 51, 28, 888, DateTimeKind.Local).AddTicks(8903));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c898988-9ae3-429d-b094-06a7f9265f4c", new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6567), "AQAAAAIAAYagAAAAEEoTxIrfuegXj5MRr4m1NKS6UqCVElzq+SlX0uwMryEGZgicXE6NOS2sd3pvlIDF9w==", "eebaec41-bb74-4564-ae9d-9c4d1157eff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8f8119-d6b8-4bef-8d81-219340f3f489", new DateTime(2026, 1, 18, 6, 45, 30, 813, DateTimeKind.Utc).AddTicks(2845), "AQAAAAIAAYagAAAAEPmsg9yGwGPfXrq1TVKsKXHu/lqGyHT/gaXFzhaaRcsztaylGj2sYqGYya0OZ6H2Gw==", "2adf041a-7009-4677-9555-eefdb76a5b75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "95fd72f7-2a9c-4d46-ba5c-272efc7188ba", 91234560, new DateTime(2026, 1, 18, 6, 45, 30, 875, DateTimeKind.Utc).AddTicks(8951), "restaurantstaff@localhost.com", "RestaurantStaff", "RESTAURANTSTAFF@LOCALHOST.COM", "RESTAURANTSTAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEq3nWP5nTss/CChvJn1pb0pWacvg0x5N2Q2kIPMgdbZ8+VtRwOS/n9Kr5sE+RCADg==", "ec1dd817-8be3-4061-b071-d5f87b290619", "restaurantstaff@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a1247e8-ee38-400c-9e5c-0787ea13b942", new DateTime(2026, 1, 18, 6, 45, 30, 937, DateTimeKind.Utc).AddTicks(1771), "AQAAAAIAAYagAAAAEIabe4IRvRpWqur4NOONSFqI9D6rj4ZFuIyYK6nuliQqmIAUJN9CYBdHbg4XLNBsqw==", "f57a9ac6-2ee2-4b0c-90f0-ac26fb6f3bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1604a64-2277-4112-ac55-f89e0b0ef856", new DateTime(2026, 1, 18, 6, 45, 30, 999, DateTimeKind.Utc).AddTicks(6936), "AQAAAAIAAYagAAAAEI1sUjItgNNKbTRxXdZ/qj9CAgfh4HulhVsOHg0Vug8nGkqK5UZEBW5jAhxLIuFt8Q==", "b45480fa-a730-4c2d-9189-224523886936" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0439c6a8-f6c8-4063-8f3f-423c859ff6c0", new DateTime(2026, 1, 18, 6, 45, 31, 59, DateTimeKind.Utc).AddTicks(6202), "AQAAAAIAAYagAAAAEHPVSW8dg12nh8OzO4iwj+jLkK0C9OBDdfF9vqSj+5KnS8JQU+BkDwRfkcv0Gp8iDA==", "38074659-4791-49d5-baa3-529b1b6af9d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8acbcb87-fdc7-4676-a672-2567be3ebfbd", new DateTime(2026, 1, 18, 6, 45, 31, 122, DateTimeKind.Utc).AddTicks(7549), "AQAAAAIAAYagAAAAECWZQngElL0GAK/D/7qZblkWuA+FwCrT8flrY39b0oaUle3pUj01zpdB6npELcdd8A==", "f3637f15-940d-4d41-b73a-d71234611a5b" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 45, 30, 751, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 14, 45, 30, 751, DateTimeKind.Local).AddTicks(6315));
        }
    }
}
