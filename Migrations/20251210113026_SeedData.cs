using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Contact", "CustomerName", "Email" },
                values: new object[,]
                {
                    { 1, 99999999, "Ryan", "banana@gmail.com" },
                    { 2, 123456789, "Oliver", "Oliver23@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "Cost", "Description", "FoodName", "MenuID", "PreOrderID", "StaffID" },
                values: new object[,]
                {
                    { 1, 3.5, "White meat", "Chicken", 1, 1, 1 },
                    { 2, 4.0, "Saba", "Fish", 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "Cost", "FoodID", "ReservationID" },
                values: new object[,]
                {
                    { 1, 3.5, 1, 1 },
                    { 2, 4.0, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PreOrder",
                columns: new[] { "PreOrderID", "Cost", "MenuID", "RestaurantID" },
                values: new object[,]
                {
                    { 1, 3.5, 1, 1 },
                    { 2, 4.0, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PreOrderItem",
                columns: new[] { "PreorderItemID", "FoodID", "PreOrderID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationID", "CustomerID", "Date", "Location", "Remarks", "RestaurantID", "StaffID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 12, 10, 19, 30, 25, 237, DateTimeKind.Local).AddTicks(6591), "Orchard", "Null", 1, 1 },
                    { 2, 2, new DateTime(2025, 12, 10, 19, 30, 25, 237, DateTimeKind.Local).AddTicks(6610), "Novena", "Null", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantID", "AdminID", "Category", "Contact", "Email", "Location", "RestaurantName" },
                values: new object[] { 1, 1, "Western", null, null, "Orchard", "WesternBanana" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewID", "CustomerID", "Date", "Description", "Location", "Rating", "RestaurantID", "ReviewTitle" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 10, 19, 30, 25, 237, DateTimeKind.Local).AddTicks(6809), "Bad", "Orchard", 2.5, 1, "Bad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "FoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PreOrder",
                keyColumn: "PreOrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PreOrder",
                keyColumn: "PreOrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PreOrderItem",
                keyColumn: "PreorderItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PreOrderItem",
                keyColumn: "PreorderItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewID",
                keyValue: 1);
        }
    }
}
