using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d03635f-47f7-483e-be2b-10bbde73714b", new DateTime(2026, 1, 18, 7, 23, 14, 930, DateTimeKind.Utc).AddTicks(1419), "RESTAURANTSTAFF@localhost.COM", "RESTAURANTSTAFF@localhost.COM", "AQAAAAIAAYagAAAAEFT7SRLfaen/RcXk0mK13TIAtT0UFOhrzq+nwVnEfZJWturVZKIeEWw5BujmjtpmVA==", "e27b65d3-48c2-440a-8272-8b7233fda675" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb9e83a-404a-4707-8365-85e226e6bbb0", new DateTime(2026, 1, 18, 7, 17, 38, 591, DateTimeKind.Utc).AddTicks(1086), "AQAAAAIAAYagAAAAEEp7vRdLmOhPwiDroqh1Iff4G9XPc1pocyj8/YFBBJB7ZXX5jvVdDpQizUStJcgWpQ==", "8e76e3be-e39b-4336-9091-3c2d1030ae1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be568b1-dacf-4fec-9328-2c534aa5616f", new DateTime(2026, 1, 18, 7, 17, 38, 654, DateTimeKind.Utc).AddTicks(4355), "RESTAURANTSTAFF@GMAIL.COM", "RESTAURANTSTAFF@GMAIL.COM", "AQAAAAIAAYagAAAAEEh3jiI/NQ2ztoeIrTOy4qV4Lh3YeGw4J/NH9rP3ofqKfkludlymCgibKE5kEtVT1w==", "8c08e102-3b22-403c-be14-4c7b27d90447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13dafd5b-4c94-47e5-a999-f2e395b60745", new DateTime(2026, 1, 18, 7, 17, 38, 80, DateTimeKind.Utc).AddTicks(1483), "AQAAAAIAAYagAAAAEIjS7drYH606Q2n3N/a0rQdW3lYsdkPxW2Ga8rLL2DRHSNwOPWTQ9BQSfGkrIv8W6Q==", "2d19ca83-d9f5-4bdc-9442-59355968d907" });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6c4326e-5b84-4519-bae5-44f35773e26c", new DateTime(2026, 1, 18, 7, 17, 38, 466, DateTimeKind.Utc).AddTicks(2321), "AQAAAAIAAYagAAAAEM4gRcikAx8p1BBuAqFBefVgxh9s1W3TEjvEvkG1txxKGfKHmzbSA9RfL8P6pgxzAw==", "e7bf079c-4936-4bd8-aa12-f4d34f3c14b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "023ed53e-cfca-44c4-a504-49ffd2ec3b68", new DateTime(2026, 1, 18, 7, 17, 38, 526, DateTimeKind.Utc).AddTicks(560), "AQAAAAIAAYagAAAAEAzxvCG6nWqaEUIau8eBVQC+8BGyzwsTJvZ0BqLE0FejznFJ9AiLx7W/Tv3xSqj+Dg==", "a2520724-2a33-49be-8f9e-f1937a2f311d" });

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
        }
    }
}
