using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d49fe1a-12bb-4873-8ee3-c7ceddc45665", new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(6145), "AQAAAAIAAYagAAAAEEQibLhguCz8jKSrKSxZ0uHrtVYA9GVw1zXan7B7DrzERK58VG2XGwEY/PUsoPUlDg==", "fe1aaf30-c84f-4241-a3ad-be3bfb6cba3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Contact", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13dafd5b-4c94-47e5-a999-f2e395b60745", 97826235, new DateTime(2026, 1, 18, 7, 17, 38, 80, DateTimeKind.Utc).AddTicks(1483), "AQAAAAIAAYagAAAAEIjS7drYH606Q2n3N/a0rQdW3lYsdkPxW2Ga8rLL2DRHSNwOPWTQ9BQSfGkrIv8W6Q==", "2d19ca83-d9f5-4bdc-9442-59355968d907" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c405678-2d9d-4b75-bd5a-06e39288c49a", new DateTime(2026, 1, 18, 7, 17, 38, 140, DateTimeKind.Utc).AddTicks(236), "AQAAAAIAAYagAAAAEIPZUJ9UoZSR9h4MkQJuochRMAX5DqvOBZ03ICvTlHc7b460xc9FY8/ElrP7SNYXFg==", "ade3a8a2-5a68-4367-9db7-f33129247933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ffb413d-1fd4-45ee-8e17-3d2febf8b306", new DateTime(2026, 1, 18, 7, 17, 38, 210, DateTimeKind.Utc).AddTicks(7312), "AQAAAAIAAYagAAAAEDz1CT+hdhYpdTJvTlhBRPsdoGaPkg1wZqAOwrs4V+VY+MN2B+1Pw8J5/wa/reVUYQ==", "d6df28d4-221a-4842-a962-23e9b4a09b39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab20959-1f4b-4c93-8ae8-2bd3f3877d26", new DateTime(2026, 1, 18, 7, 17, 38, 273, DateTimeKind.Utc).AddTicks(9313), "AQAAAAIAAYagAAAAEG0uBoptzaL2XHpPd+bLkoosvUJhb6e3FZVBhy//nBrPQUeIMnu1ZXXQXwJglHaEuQ==", "9f5e7258-1a65-47a6-b186-e10aa557d90e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42f80519-454d-4ef8-b2d5-0dc2b52cc024", new DateTime(2026, 1, 18, 7, 17, 38, 337, DateTimeKind.Utc).AddTicks(7225), "AQAAAAIAAYagAAAAEJtdBaox/nupeUJB0eiPaEOfWQ0A8yCvv4fw7OaaPBBDxtrFfLfN7WW3A/2l4mGQuQ==", "bfced823-1587-4da2-90e9-11539ac3cc95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98c31ad3-f30f-4693-b643-16320fe07175", new DateTime(2026, 1, 18, 7, 17, 38, 403, DateTimeKind.Utc).AddTicks(17), "AQAAAAIAAYagAAAAENEDEjzh3NUJoFxHNM3CCcIVQSruenIJdYLrO9JHRS3+gCb7qwqR91+GTAdeByJSBA==", "d7f4f2fe-6311-4cbf-870f-0d0763064b4d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "EmailConfirmed", "LastLoginAtUtc", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, "3fb9e83a-404a-4707-8365-85e226e6bbb0", 97629623, new DateTime(2026, 1, 18, 7, 17, 38, 591, DateTimeKind.Utc).AddTicks(1086), "dustindomingo@gmail.com", true, null, false, null, "Dustin", "DUSTINDOMINGO@GMAIL.COM", "DUSTINDOMINGO@GMAIL.COM", "AQAAAAIAAYagAAAAEEp7vRdLmOhPwiDroqh1Iff4G9XPc1pocyj8/YFBBJB7ZXX5jvVdDpQizUStJcgWpQ==", null, false, "8e76e3be-e39b-4336-9091-3c2d1030ae1b", false, "dustindomingo@gmail.com" },
                    { "11", 0, "7be568b1-dacf-4fec-9328-2c534aa5616f", 97237323, new DateTime(2026, 1, 18, 7, 17, 38, 654, DateTimeKind.Utc).AddTicks(4355), "restaurantstaff@localhost.com", true, null, false, null, "RestaurantStaff", "RESTAURANTSTAFF@GMAIL.COM", "RESTAURANTSTAFF@GMAIL.COM", "AQAAAAIAAYagAAAAEEh3jiI/NQ2ztoeIrTOy4qV4Lh3YeGw4J/NH9rP3ofqKfkludlymCgibKE5kEtVT1w==", null, false, "8c08e102-3b22-403c-be14-4c7b27d90447", false, "restaurantstaff@localhost.com" },
                    { "8", 0, "c6c4326e-5b84-4519-bae5-44f35773e26c", 96409718, new DateTime(2026, 1, 18, 7, 17, 38, 466, DateTimeKind.Utc).AddTicks(2321), "oliverchay@gmail.com", true, null, false, null, "Oliver", "OLIVERCHAY@GMAIL.COM", "OLIVERCHAY@GMAIL.COM", "AQAAAAIAAYagAAAAEM4gRcikAx8p1BBuAqFBefVgxh9s1W3TEjvEvkG1txxKGfKHmzbSA9RfL8P6pgxzAw==", null, false, "e7bf079c-4936-4bd8-aa12-f4d34f3c14b2", false, "oliverchay@gmailcom" },
                    { "9", 0, "023ed53e-cfca-44c4-a504-49ffd2ec3b68", 93278292, new DateTime(2026, 1, 18, 7, 17, 38, 526, DateTimeKind.Utc).AddTicks(560), "ryanneo@gmail.com", true, null, false, null, "Ryan", "RYANNEO@GMAIL.COM", "RYANNEO@GMAIL.COM", "AQAAAAIAAYagAAAAEAzxvCG6nWqaEUIau8eBVQC+8BGyzwsTJvZ0BqLE0FejznFJ9AiLx7W/Tv3xSqj+Dg==", null, false, "a2520724-2a33-49be-8f9e-f1937a2f311d", false, "ryanneo@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "DinesaurUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contact",
                value: 97826235);

            migrationBuilder.InsertData(
                table: "DinesaurUser",
                columns: new[] { "Id", "Contact", "DinesaurUserID", "DinesaurUserName", "Email" },
                values: new object[,]
                {
                    { 2, 96409718, "8", "Oliver", "user@localhost.com" },
                    { 3, 93278292, "9", "Ryan", "user@localhost.com" },
                    { 4, 97629623, "10", "Dustin", "dustindomingo@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 17, 38, 20, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 17, 38, 20, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "10" },
                    { "3", "11" },
                    { "2", "8" },
                    { "2", "9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "9" });

            migrationBuilder.DeleteData(
                table: "DinesaurUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DinesaurUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DinesaurUser",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

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
                columns: new[] { "ConcurrencyStamp", "Contact", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "181ead17-b035-4076-aadd-57593849cf7b", 91234568, new DateTime(2026, 1, 18, 6, 51, 28, 949, DateTimeKind.Utc).AddTicks(4771), "AQAAAAIAAYagAAAAENvqINl7BMF8bOGKp2cShtdSn2p0XiWvfYUkbxMi0mdHW2Bz+NU7G+F6irCaDF2ALQ==", "b2c206e0-22b4-4a32-aad1-4a3a6d23f882" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f19afdf-31a1-4475-a74d-e232412f26d9", new DateTime(2026, 1, 18, 6, 51, 29, 9, DateTimeKind.Utc).AddTicks(3579), "AQAAAAIAAYagAAAAEAYhHE7isl94Ev0EqYMTEsZB2wTYm548+Yfyz8oLFbGB62qFBzs0PrkTw5hCxkOYvA==", "c63d7b32-e068-4003-b78d-6407e4963702" });

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
                table: "DinesaurUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contact",
                value: 91234568);

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
    }
}
