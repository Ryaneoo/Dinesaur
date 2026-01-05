using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:Migrations/20260105062525_Initial.cs
    public partial class Initial : Migration
========
    public partial class initial : Migration
>>>>>>>> ffaf69d46da323adc6b6a383222b18309ab843f8:Migrations/20260105064434_initial.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreviousLoginAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DinesaurUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DinesaurUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DinesaurUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinesaurUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "PreOrder",
                columns: table => new
                {
                    PreOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreOrder", x => x.PreOrderID);
                });

            migrationBuilder.CreateTable(
                name: "PreOrderItem",
                columns: table => new
                {
                    PreorderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PreOrderID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreOrderItem", x => x.PreorderItemID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pax = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantOwnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantID);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "User", "USER" },
                    { "3", null, "RestaurantStaff", "RESTAURANTSTAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "EmailConfirmed", "LastLoginAtUtc", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreviousLoginAtUtc", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Migrations/20260105062525_Initial.cs
                    { "1", 0, "2223e032-d411-4fc7-adf0-1b43b03cf423", 91234567, new DateTime(2026, 1, 5, 6, 25, 24, 344, DateTimeKind.Utc).AddTicks(8067), "admin@localhost.com", true, null, false, null, "Admin", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFD1NEKSsTNjzKZ1dSAc2RM4otyzTG5pPXkCZFIZNAO9wOZo3PpbRt/J+TywoN8AfQ==", null, false, null, "437164d9-0158-4970-8de1-83858d11e509", false, "admin@localhost.com" },
                    { "2", 0, "f6c2746b-178a-4f19-a73b-b0eedbd80703", 91234568, new DateTime(2026, 1, 5, 6, 25, 24, 407, DateTimeKind.Utc).AddTicks(7683), "user@localhost.com", true, null, false, null, "User", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAELEsuRV/b8a8sWAKulifux9ZBJ9HM9mF85TT5mC+OfE4k4FKsYR1CDJPiu1tnGcPXw==", null, false, null, "e8e1ca2a-73ab-42ab-880b-fc00a026c3c0", false, "user@localhost.com" },
                    { "3", 0, "98f59a8a-6006-4869-85bb-0e9405cdeeda", 91234560, new DateTime(2026, 1, 5, 6, 25, 24, 463, DateTimeKind.Utc).AddTicks(4963), "restaurantstaff@localhost.com", true, null, false, null, "RestaurantStaff", "RESTAURANTSTAFF@LOCALHOST.COM", "RESTAURANTSTAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJv7AEmx2CI8iHfCpa77TmoLXlHR3xwHKqyJO0C1w3eS4WPYjewRYB5b3/342WnnuA==", null, false, null, "5a92e8f6-5c3e-494e-a587-b9687de00c7b", false, "restaurantstaff@localhost.com" }
========
                    { "1", 0, "703b9502-aaeb-45c0-8776-488d32573720", 91234567, new DateTime(2026, 1, 5, 6, 44, 32, 818, DateTimeKind.Utc).AddTicks(4931), "admin@localhost.com", true, null, false, null, "Admin", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFXcY5GjLbOcquv62O0/exC5UBQvNrvUPbdjVk2B6BCsoDyyAl049bCRFLvaf+k3Ww==", null, false, null, "1d0439bc-0bc3-43de-8ed6-df9ef31bf42e", false, "admin@localhost.com" },
                    { "2", 0, "5c41e89b-a0f6-4df3-a6a5-b1d5766e4cb5", 91234568, new DateTime(2026, 1, 5, 6, 44, 32, 895, DateTimeKind.Utc).AddTicks(4613), "user@localhost.com", true, null, false, null, "User", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAED+gFJu4+jUO+vSBY5jTORTGPZfTHk6fWlh3hMGkxODCeAglF8ixEM1ybLML6IebvQ==", null, false, null, "c88c7842-d9a4-4e87-a194-499868b4d2cd", false, "user@localhost.com" },
                    { "3", 0, "cb930fc8-f892-493f-9c4b-d18a42342865", 91234560, new DateTime(2026, 1, 5, 6, 44, 32, 975, DateTimeKind.Utc).AddTicks(2892), "restaurantstaff@localhost.com", true, null, false, null, "RestaurantStaff", "RESTAURANTSTAFF@LOCALHOST.COM", "RESTAURANTSTAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOI+uk0WD9W2js7c2G8WvEVQYFmzyBsMpjrY/RhvLLoSTIeJPVSudZhR+vbAPBPqKw==", null, false, null, "2942e756-5e24-48ab-b3e8-2a185406f566", false, "restaurantstaff@localhost.com" }
>>>>>>>> ffaf69d46da323adc6b6a383222b18309ab843f8:Migrations/20260105064434_initial.cs
                });

            migrationBuilder.InsertData(
                table: "DinesaurUser",
                columns: new[] { "Id", "Contact", "DinesaurUserID", "DinesaurUserName", "Email" },
                values: new object[] { 1, 91234568, "2", "User", "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "Cost", "Description", "FoodName", "Image", "MenuID", "StaffID" },
                values: new object[,]
                {
                    { 1, 3.5, "White meat", "Chicken", "[]", 1, 1 },
                    { 2, 4.0, "Saba", "Fish", "[]", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "RestaurantID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
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
                columns: new[] { "ReservationID", "CustomerID", "EndDate", "Pax", "Remarks", "RestaurantID", "StartDate", "Status" },
                values: new object[,]
                {
<<<<<<<< HEAD:Migrations/20260105062525_Initial.cs
                    { 1, "2", new DateTime(2026, 1, 5, 16, 25, 24, 344, DateTimeKind.Local).AddTicks(7708), 0, null, 1, new DateTime(2026, 1, 5, 14, 25, 24, 344, DateTimeKind.Local).AddTicks(7695), 1 },
                    { 2, "2", new DateTime(2026, 1, 5, 16, 25, 24, 344, DateTimeKind.Local).AddTicks(7715), 0, "Null", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "2", new DateTime(2026, 1, 5, 16, 25, 24, 344, DateTimeKind.Local).AddTicks(7717), 0, "Null", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, "2", new DateTime(2026, 1, 5, 16, 25, 24, 344, DateTimeKind.Local).AddTicks(7719), 0, "Null", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
========
                    { 1, "1", new DateTime(2026, 1, 5, 16, 44, 32, 818, DateTimeKind.Local).AddTicks(4160), 0, null, 1, new DateTime(2026, 1, 5, 14, 44, 32, 818, DateTimeKind.Local).AddTicks(4127), "Pending" },
                    { 2, "1", new DateTime(2026, 1, 5, 16, 44, 32, 818, DateTimeKind.Local).AddTicks(4179), 0, "Null", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" }
>>>>>>>> ffaf69d46da323adc6b6a383222b18309ab843f8:Migrations/20260105064434_initial.cs
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantID", "AdminID", "Category", "Contact", "Email", "Location", "Logo", "RestaurantName", "RestaurantOwnerID", "Status" },
                values: new object[] { 1, 1, "Western", null, null, "Orchard", "[]", "WesternBanana", "3", 0 });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewID", "Date", "Description", "Rating", "RestaurantID", "ReviewTitle", "Status" },
<<<<<<<< HEAD:Migrations/20260105062525_Initial.cs
                values: new object[] { 1, new DateTime(2026, 1, 5, 14, 25, 24, 344, DateTimeKind.Local).AddTicks(7897), "Bad", 2.5, 1, "Bad", 0 });
========
                values: new object[] { 1, new DateTime(2026, 1, 5, 14, 44, 32, 818, DateTimeKind.Local).AddTicks(4501), "Bad", 2.5, 1, "Bad", 0 });
>>>>>>>> ffaf69d46da323adc6b6a383222b18309ab843f8:Migrations/20260105064434_initial.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DinesaurUser");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "PreOrder");

            migrationBuilder.DropTable(
                name: "PreOrderItem");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
