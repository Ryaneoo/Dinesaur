using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class newest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1fd8de3-321b-43f9-9202-3482dc3f479d", new DateTime(2026, 1, 1, 15, 1, 53, 888, DateTimeKind.Utc).AddTicks(7872), "AQAAAAIAAYagAAAAEJN375+75tkE375eGgqC6yrKG0dVvDk8kAZ+g4L9ncDMYTV6g/WYOAOTRaJUPGac2Q==", "33f8444b-4ac2-487e-87cb-42f4d01258b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38c2f5a3-21e5-4a1b-8041-cdffe28eae14", new DateTime(2026, 1, 1, 15, 1, 53, 945, DateTimeKind.Utc).AddTicks(657), "AQAAAAIAAYagAAAAED9wmdtDFzlj2H6tO/M5fZleOCK9Kfcn6z2Ep9QmCI0dJN4p+FNCFcufnSUCCe9+QA==", "0ffc3cf1-50b2-47a4-918f-d1071a364a8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8973fb5d-01ba-4e87-b0e5-48601fce7abc", new DateTime(2026, 1, 1, 15, 1, 54, 1, DateTimeKind.Utc).AddTicks(2994), "AQAAAAIAAYagAAAAEKJYhVJYsDVwjRAsN+l8ExZcoRcPCKz/QRctSRTlseh/BrU+PHgnwGd/kFGROAQiYA==", "116fe03f-eff6-4551-84c3-e661a8cb1509" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 23, 1, 53, 888, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 1, 23, 1, 53, 888, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 23, 1, 53, 888, DateTimeKind.Local).AddTicks(7502));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb726a4e-c2ce-4977-aae4-f10bb7c2bf65", new DateTime(2026, 1, 1, 14, 53, 29, 674, DateTimeKind.Utc).AddTicks(2818), "AQAAAAIAAYagAAAAEK+z6vQU9eIN9xfJ/8/6w5npkRT+7ypgNEw2cbNLhwNW7adig0+TPdlhr6drk9swPw==", "b5d8966f-0b7a-4952-8669-177e0e5a4658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d29d569-e143-42a6-80d2-cd3e3c3c4a60", new DateTime(2026, 1, 1, 14, 53, 29, 731, DateTimeKind.Utc).AddTicks(6431), "AQAAAAIAAYagAAAAELrYwyUHRjeQKeM/o1tII0yOBgYbXcGxoKy/LuMayDN2h+26hRiEEtW50uOWFK7B+g==", "55eddb57-b650-48a7-a61b-27509df19bff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAtUtc", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca51db04-24c5-4fe2-870e-ca87685edfa9", new DateTime(2026, 1, 1, 14, 53, 29, 792, DateTimeKind.Utc).AddTicks(8262), "AQAAAAIAAYagAAAAEI3LSfQDFOFgMefX2yywXYMjErX1flkG6gHfZ9sOrSiO64ERwP3x/sqotRW5FLAPvA==", "b7d1f268-94ce-4688-a6d0-15619c7e79b3" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 1, 1, 22, 53, 29, 674, DateTimeKind.Local).AddTicks(2532));
        }
    }
}
