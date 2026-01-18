using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95fd72f7-2a9c-4d46-ba5c-272efc7188ba", new DateTime(2026, 1, 18, 6, 45, 30, 875, DateTimeKind.Utc).AddTicks(8951), "AQAAAAIAAYagAAAAEEq3nWP5nTss/CChvJn1pb0pWacvg0x5N2Q2kIPMgdbZ8+VtRwOS/n9Kr5sE+RCADg==", "ec1dd817-8be3-4061-b071-d5f87b290619" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9a1247e8-ee38-400c-9e5c-0787ea13b942", new DateTime(2026, 1, 18, 6, 45, 30, 937, DateTimeKind.Utc).AddTicks(1771), "BUTCHERBLOCK@GMAIL.COM", "AQAAAAIAAYagAAAAEIabe4IRvRpWqur4NOONSFqI9D6rj4ZFuIyYK6nuliQqmIAUJN9CYBdHbg4XLNBsqw==", "f57a9ac6-2ee2-4b0c-90f0-ac26fb6f3bdb", "ButcherBlock@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f1604a64-2277-4112-ac55-f89e0b0ef856", new DateTime(2026, 1, 18, 6, 45, 30, 999, DateTimeKind.Utc).AddTicks(6936), "LABULA@GMAIL.COM", "AQAAAAIAAYagAAAAEI1sUjItgNNKbTRxXdZ/qj9CAgfh4HulhVsOHg0Vug8nGkqK5UZEBW5jAhxLIuFt8Q==", "b45480fa-a730-4c2d-9189-224523886936", "labula@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0439c6a8-f6c8-4063-8f3f-423c859ff6c0", new DateTime(2026, 1, 18, 6, 45, 31, 59, DateTimeKind.Utc).AddTicks(6202), "CHEFHATS@GMAIL.COM", "AQAAAAIAAYagAAAAEHPVSW8dg12nh8OzO4iwj+jLkK0C9OBDdfF9vqSj+5KnS8JQU+BkDwRfkcv0Gp8iDA==", "38074659-4791-49d5-baa3-529b1b6af9d3", "chefhats@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8acbcb87-fdc7-4676-a672-2567be3ebfbd", new DateTime(2026, 1, 18, 6, 45, 31, 122, DateTimeKind.Utc).AddTicks(7549), "TDP@GMAIL.COM", "AQAAAAIAAYagAAAAECWZQngElL0GAK/D/7qZblkWuA+FwCrT8flrY39b0oaUle3pUj01zpdB6npELcdd8A==", "f3637f15-940d-4d41-b73a-d71234611a5b", "tdp@gmail.com" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c85f52a1-710b-443d-9afb-42828ea090ba", new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(5080), "AQAAAAIAAYagAAAAEAj5VbwJqHvmGpToIKziHnysE8RndieaEH6gC3SRLmqbbnDU+/QoREleLj5bmfDpQw==", "e1a2b13a-c629-4f56-852b-7ad07dc22d0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a8a151a-a01b-49c7-aaab-e95b27c9935a", new DateTime(2026, 1, 18, 6, 40, 55, 887, DateTimeKind.Utc).AddTicks(1796), "AQAAAAIAAYagAAAAEDBfmwYI2FhL179KbkyyIPOS4xaca7zlrn/ckpDC6i8Yg88kUR42tS1kmIC1OX8jMw==", "87ad5585-5832-4ee8-819e-b02c0d7eafcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0614c457-56b2-4109-a5cc-025cd5aad32d", new DateTime(2026, 1, 18, 6, 40, 55, 955, DateTimeKind.Utc).AddTicks(6760), "AQAAAAIAAYagAAAAECEU/fNbKKT5b38KMLw6a/Os+gqL/f5075607lw9tCUveLjvrQ9BfPXPfHWh91kKzg==", "30c7b566-09bf-485f-be64-61d99a4a74fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6f9a77b-8b31-475a-9940-1cf384e33b39", new DateTime(2026, 1, 18, 6, 40, 56, 35, DateTimeKind.Utc).AddTicks(3927), "BUTCHERADMIN", "AQAAAAIAAYagAAAAEAhDFYqL97A6duAILkFjA4UNSzqm2+TjDXJ1hi9YU0Nkb6EbfBudfup0cS0FNx2sqw==", "8896e3a7-4a6c-47ff-bc30-d4623e9b91ef", "ButcherAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c77df5c0-b65a-40c0-8328-b626e3000369", new DateTime(2026, 1, 18, 6, 40, 56, 117, DateTimeKind.Utc).AddTicks(6102), "LabulaAdmin", "AQAAAAIAAYagAAAAEIf1x1rws4zGS0iOFevW6tvrx3xYBiifl0e7anmNvaIXAKeN1QEjHE3QNoxhKvdGEQ==", "986fbaa3-fee0-46db-8bd2-96f1256142d1", "LabulaAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "43e77fff-8f09-4d33-9313-f86d535e9d84", new DateTime(2026, 1, 18, 6, 40, 56, 175, DateTimeKind.Utc).AddTicks(2579), "CHEFHATSADMIN", "AQAAAAIAAYagAAAAEJi4WrI/sTtlZiovDNvAFy7pjrmUTk/q7j9yO8KVlqlMyNFxCGx/s5CoIvgWq1ncbQ==", "caaf931e-738c-4b0c-a69b-94f6f6daa9ea", "ChefHatsAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "abc025d2-d532-479f-afa6-14a82209588f", new DateTime(2026, 1, 18, 6, 40, 56, 256, DateTimeKind.Utc).AddTicks(8308), "TDPADMIN", "AQAAAAIAAYagAAAAENKXGDUc3IsPBZsJEj+uiAkOZrmTOO4Mve2VetfuLS2g4vZ7kFCBKOwlABW2ETlzbQ==", "27c6f783-8a19-425d-9208-c0ddb871d5ab", "TDPAdmin" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 14, 40, 55, 823, DateTimeKind.Local).AddTicks(4833));
        }
    }
}
