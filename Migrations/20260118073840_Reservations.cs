using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class Reservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255948dd-8975-4ca2-8aea-4bc3eeae4d7a", new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8891), "AQAAAAIAAYagAAAAEKwt7AcYjNFAa2Mk532g1N/CSH3NQQ3TqqtHoLlwwFWOYF5B5C6N9FxaOPSN+i1Wxw==", "9c20ccc8-06fa-4328-8eec-7c37a729b2f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "483f840e-40aa-4428-85c6-5097b27248bd", new DateTime(2026, 1, 18, 7, 38, 39, 181, DateTimeKind.Utc).AddTicks(3096), "AQAAAAIAAYagAAAAEEK/OvZPSdiDQJvX4q/QZ2GfUXTafKVB6UGOcwDnJBEoV0SkpbtFYSl2CPvD4rCptg==", "fb5a371a-4de7-44e2-8579-8d4843d527a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28feecac-2e92-4201-b815-9de8d9f6af30", new DateTime(2026, 1, 18, 7, 38, 39, 253, DateTimeKind.Utc).AddTicks(7867), "AQAAAAIAAYagAAAAEASPYq12ZwLhBqT/ww9ePejtsfQ4QA3gaNb2qkU/gyKsv34v9mH9+0nfHrLPGQKpPg==", "7cbda118-7c53-4b78-a927-f3acda56b521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b3cb06-e24d-4e99-9f75-28bf416e8448", new DateTime(2026, 1, 18, 7, 38, 38, 697, DateTimeKind.Utc).AddTicks(773), "AQAAAAIAAYagAAAAEK4vNGybMxTTJzULYAv0l5VK0hy3yz7MtduboVFFcTX8rikGUOIfZkCKNyqik2FGJg==", "49adf9f7-5a31-47e5-97df-75e064acb7a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7d4e172-f230-4fd6-b51d-da397ef17917", new DateTime(2026, 1, 18, 7, 38, 38, 754, DateTimeKind.Utc).AddTicks(2020), "AQAAAAIAAYagAAAAEGp45NrmEGD1eiOqg+oGXh2h/OwlYLdba+grXtcdZCb40VpphIXXtGkU6ObW7QboYA==", "c94b1fce-93a6-4b8c-bb03-a7ab4fac8884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73d23d5-14b2-4bef-a470-44067b5696bf", new DateTime(2026, 1, 18, 7, 38, 38, 814, DateTimeKind.Utc).AddTicks(2611), "AQAAAAIAAYagAAAAEH4yr//s0lk6DYIxjXFk8JUbwasM1IJ+mVg97nItW0ZSZHSZAuZSPTIYOYUAKdviWg==", "ed3eae25-75ae-414b-944e-fe35a8204d0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75a0a350-ebaa-4df8-9c4e-3660866ff9dc", new DateTime(2026, 1, 18, 7, 38, 38, 875, DateTimeKind.Utc).AddTicks(6920), "AQAAAAIAAYagAAAAEMWfFQWnYJsnuiRRBfxiFUiQq+FUMxuq2aVaBmWkW0UF8HaWEH1qkrbC5o45U7NS5g==", "1e98ebad-6314-4aef-9d7d-b4ce2ce48ce3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a879e6-497c-4a8e-b9bb-f7943b82e12a", new DateTime(2026, 1, 18, 7, 38, 38, 938, DateTimeKind.Utc).AddTicks(2260), "AQAAAAIAAYagAAAAEA3Y+r3rrL90kng+XGzwswIVZU0yMau2M+au2YJdt6tT2R51rz+71A3cMrMrGDVuWA==", "f8c7e583-16d4-4c58-a4f5-4233cad8e67f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8065d38c-e113-43d7-8983-c30d29b6740c", new DateTime(2026, 1, 18, 7, 38, 38, 996, DateTimeKind.Utc).AddTicks(5177), "AQAAAAIAAYagAAAAEG02e0jwkZwoO1/jvIMVKQETIT2G6GiZVudtSg0IklyA0Aok6cpA5m6mQweV8wToCw==", "6d2157f1-c31e-4ae9-9d1d-2788d5102909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24c196b9-925a-4827-ba5c-6a41f845baeb", new DateTime(2026, 1, 18, 7, 38, 39, 58, DateTimeKind.Utc).AddTicks(960), "AQAAAAIAAYagAAAAEOfZQg2Wiix5Uj7aLRUhfW7vdPZRdy7c+QADGGTx2PGjGsibGJKgbDqJDYt5/CcPjg==", "0c3b7e49-53ec-4dbe-b34b-21557b37ceb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8def1e1a-61b6-40de-830c-c8918eef1f3c", new DateTime(2026, 1, 18, 7, 38, 39, 121, DateTimeKind.Utc).AddTicks(5134), "AQAAAAIAAYagAAAAEK3fSbNW8KXvDQlwWoWqgZQ9asUL0meCfr1RVzuvV8RyzHOKh/TiUPHHyeCsPQ9FDQ==", "71110b61-739c-4880-b22c-dd11269313f4" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "CustomerID", "Date", "Status" },
                values: new object[] { "8", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "CustomerID", "Date", "RestaurantID", "Status", "Time" },
                values: new object[] { "8", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new TimeOnly(18, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 3,
                columns: new[] { "CustomerID", "Date", "Pax", "Remarks", "Status", "Time" },
                values: new object[] { "8", new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "1 Baby Chair", 4, new TimeOnly(13, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 4,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Time" },
                values: new object[] { "9", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new TimeOnly(14, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 5,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Status", "Time" },
                values: new object[] { "9", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 3, new TimeOnly(19, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 6,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Status", "Time" },
                values: new object[] { "9", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 1, new TimeOnly(14, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 38, 38, 639, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 38, 38, 639, DateTimeKind.Local).AddTicks(8588));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5da0b5d3-7f62-4199-b599-be85e73cf0f1", new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4517), "AQAAAAIAAYagAAAAECZV/uGPVl0sHGlUAPLY5ESE1JVwDrFDD0zb2keNO8UBJ1yu4z3esr0a7wUBbA0C+g==", "4a162695-f5ee-4eec-8fc2-08a6f81a269a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdf159e1-8a3e-4dfb-a2cb-d732a62c512b", new DateTime(2026, 1, 18, 7, 23, 14, 870, DateTimeKind.Utc).AddTicks(274), "AQAAAAIAAYagAAAAEJMEJJfIC6G08rSIgRk3YJx0i375qjiNaSedmTZizJQf+v4azqBFstaFdg7QSmQqXA==", "eb0c2ccb-fb63-4b1d-97f1-24a92c82210e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d03635f-47f7-483e-be2b-10bbde73714b", new DateTime(2026, 1, 18, 7, 23, 14, 930, DateTimeKind.Utc).AddTicks(1419), "AQAAAAIAAYagAAAAEFT7SRLfaen/RcXk0mK13TIAtT0UFOhrzq+nwVnEfZJWturVZKIeEWw5BujmjtpmVA==", "e27b65d3-48c2-440a-8272-8b7233fda675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d0c9ca-4e43-410e-9154-abc9de9713e0", new DateTime(2026, 1, 18, 7, 23, 14, 369, DateTimeKind.Utc).AddTicks(9479), "AQAAAAIAAYagAAAAENHsAbtXGkcpGAW0OFeAM5EvO3NA3GziIUxWTTM4aQfSi4hdxFSLwkMQut53u5/Pfw==", "47bd808c-30b3-428d-b95f-bb8cc541b9cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58d6498-7074-4c7b-9a69-b0d1aef22e50", new DateTime(2026, 1, 18, 7, 23, 14, 432, DateTimeKind.Utc).AddTicks(7456), "AQAAAAIAAYagAAAAEO+MHpEM2YuF0+UDu99C/CEz8IP6Z//BjS5zr1ReiKMC4zR7sLLB3YUpDNnFKHne/w==", "bac088a5-72d9-4669-bf95-0151f9eac523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eadbb051-6a9e-4c95-b032-d3303c7e8a4c", new DateTime(2026, 1, 18, 7, 23, 14, 491, DateTimeKind.Utc).AddTicks(8645), "AQAAAAIAAYagAAAAEPJV8xbfTaI7SLUQ93LNC04NqEHrzjT/BAzKrHXyc0PoJ0BXBYWj7dskiLQr1f0NxA==", "208b954b-b586-4181-bd11-22643d033340" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df2e0b27-7447-49c3-b7f6-b929574b06d5", new DateTime(2026, 1, 18, 7, 23, 14, 553, DateTimeKind.Utc).AddTicks(3095), "AQAAAAIAAYagAAAAEKkwWRX2CXKbhkh6WRiA2ZRdUx4jOJ1ydeObrIjspK4ZlSSbYYeuM9nEC+N08XkgaQ==", "1d37847e-273f-43cf-92f8-561b6573dd66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38eada82-da64-44cf-8b85-ebe8d2741903", new DateTime(2026, 1, 18, 7, 23, 14, 621, DateTimeKind.Utc).AddTicks(2872), "AQAAAAIAAYagAAAAEBG1O7PXvNnloCTworEVpVlWvhAsyxK3X07Buolx/nmOhkKJSYVR8WwKKJvYDSTvCg==", "3a7a3599-3b50-4ec8-9185-e667936c0db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39248ef6-108b-4420-b83a-b25eacf509bd", new DateTime(2026, 1, 18, 7, 23, 14, 689, DateTimeKind.Utc).AddTicks(2064), "AQAAAAIAAYagAAAAEKfSCpU6kgbBEdRiSJy6XEDmEhJwkboZqKdEVQ7QhDsJDHgOtxlZUsN4CjTEc10qHA==", "9ed59dc7-a0d1-4b2e-975a-e7d54cd321b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3762d78-f365-4e27-907c-656064ed9c5d", new DateTime(2026, 1, 18, 7, 23, 14, 746, DateTimeKind.Utc).AddTicks(2556), "AQAAAAIAAYagAAAAEL9d8AF/g9AdP3jWvO1W7sbdc/yP174WN8JuzuONpvJMpshgTvFNLAHytLyEHIz2kQ==", "de78f588-078b-42ae-b091-02a1e792377f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86e7935f-7da0-48bc-bff2-afd499c63da7", new DateTime(2026, 1, 18, 7, 23, 14, 810, DateTimeKind.Utc).AddTicks(7061), "AQAAAAIAAYagAAAAEAP21zOwlRD7DywehxnxIvOnVcW7a3IAUZ/VcrVgyIXE0YykY/I1nweHSnDazSt/Rg==", "51848b75-e7b1-4366-9826-5294ed4b8e6b" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1,
                columns: new[] { "CustomerID", "Date", "Status" },
                values: new object[] { "2", new DateTime(2026, 1, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2,
                columns: new[] { "CustomerID", "Date", "RestaurantID", "Status", "Time" },
                values: new object[] { "2", new DateTime(2026, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new TimeOnly(12, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 3,
                columns: new[] { "CustomerID", "Date", "Pax", "Remarks", "Status", "Time" },
                values: new object[] { "2", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "N/A", 3, new TimeOnly(12, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 4,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Time" },
                values: new object[] { "2", new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, new TimeOnly(12, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 5,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Status", "Time" },
                values: new object[] { "2", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 1, new TimeOnly(12, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 6,
                columns: new[] { "CustomerID", "Date", "Pax", "RestaurantID", "Status", "Time" },
                values: new object[] { "2", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3, new TimeOnly(12, 30, 0) });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationID", "CustomerID", "Date", "Pax", "Remarks", "RestaurantID", "ReviewID", "Status", "Time" },
                values: new object[,]
                {
                    { 7, "2", new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) },
                    { 8, "2", new DateTime(2025, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 2,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 3,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 4,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 5,
                column: "CreatedAtUtc",
                value: new DateTime(2026, 1, 18, 7, 23, 14, 312, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 18, 15, 23, 14, 312, DateTimeKind.Local).AddTicks(4276));
        }
    }
}
