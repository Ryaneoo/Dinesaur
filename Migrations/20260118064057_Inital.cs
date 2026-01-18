using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dinesaur.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
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
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffID = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Catergories = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ReservationID = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Pax = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    ReviewID = table.Column<int>(type: "int", nullable: true),
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
                    OpeningHours = table.Column<TimeOnly>(type: "time", nullable: false),
                    ClosingHours = table.Column<TimeOnly>(type: "time", nullable: false),
                    RestaurantOwnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Contact", "CreatedAtUtc", "Email", "EmailConfirmed", "LastLoginAtUtc", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "c85f52a1-710b-443d-9afb-42828ea090ba", 91234567, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(5080), "admin@localhost.com", true, null, false, null, "Admin", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAj5VbwJqHvmGpToIKziHnysE8RndieaEH6gC3SRLmqbbnDU+/QoREleLj5bmfDpQw==", null, false, "e1a2b13a-c629-4f56-852b-7ad07dc22d0a", false, "admin@localhost.com" },
                    { "2", 0, "3a8a151a-a01b-49c7-aaab-e95b27c9935a", 91234568, new DateTime(2026, 1, 18, 6, 40, 55, 887, DateTimeKind.Utc).AddTicks(1796), "user@localhost.com", true, null, false, null, "User", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDBfmwYI2FhL179KbkyyIPOS4xaca7zlrn/ckpDC6i8Yg88kUR42tS1kmIC1OX8jMw==", null, false, "87ad5585-5832-4ee8-819e-b02c0d7eafcd", false, "user@localhost.com" },
                    { "3", 0, "0614c457-56b2-4109-a5cc-025cd5aad32d", 91234560, new DateTime(2026, 1, 18, 6, 40, 55, 955, DateTimeKind.Utc).AddTicks(6760), "restaurantstaff@localhost.com", true, null, false, null, "RestaurantStaff", "RESTAURANTSTAFF@LOCALHOST.COM", "RESTAURANTSTAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAECEU/fNbKKT5b38KMLw6a/Os+gqL/f5075607lw9tCUveLjvrQ9BfPXPfHWh91kKzg==", null, false, "30c7b566-09bf-485f-be64-61d99a4a74fd", false, "restaurantstaff@localhost.com" },
                    { "4", 0, "e6f9a77b-8b31-475a-9940-1cf384e33b39", 82613992, new DateTime(2026, 1, 18, 6, 40, 56, 35, DateTimeKind.Utc).AddTicks(3927), "ButcherBlock@gmail.com", true, null, false, null, "ButcherAdmin", "BUTCHERBLOCK@GMAIL.COM", "BUTCHERADMIN", "AQAAAAIAAYagAAAAEAhDFYqL97A6duAILkFjA4UNSzqm2+TjDXJ1hi9YU0Nkb6EbfBudfup0cS0FNx2sqw==", null, false, "8896e3a7-4a6c-47ff-bc30-d4623e9b91ef", false, "ButcherAdmin" },
                    { "5", 0, "c77df5c0-b65a-40c0-8328-b626e3000369", 88706606, new DateTime(2026, 1, 18, 6, 40, 56, 117, DateTimeKind.Utc).AddTicks(6102), "labula@gmail.com", true, null, false, null, "LabulaAdmin", "LABULA@GMAIL.COM", "LabulaAdmin", "AQAAAAIAAYagAAAAEIf1x1rws4zGS0iOFevW6tvrx3xYBiifl0e7anmNvaIXAKeN1QEjHE3QNoxhKvdGEQ==", null, false, "986fbaa3-fee0-46db-8bd2-96f1256142d1", false, "LabulaAdmin" },
                    { "6", 0, "43e77fff-8f09-4d33-9313-f86d535e9d84", 94799101, new DateTime(2026, 1, 18, 6, 40, 56, 175, DateTimeKind.Utc).AddTicks(2579), "chefhats@gmail.com", true, null, false, null, "ChefHatsAdmin", "CHEFHATS@GMAIL.COM", "CHEFHATSADMIN", "AQAAAAIAAYagAAAAEJi4WrI/sTtlZiovDNvAFy7pjrmUTk/q7j9yO8KVlqlMyNFxCGx/s5CoIvgWq1ncbQ==", null, false, "caaf931e-738c-4b0c-a69b-94f6f6daa9ea", false, "ChefHatsAdmin" },
                    { "7", 0, "abc025d2-d532-479f-afa6-14a82209588f", 91234560, new DateTime(2026, 1, 18, 6, 40, 56, 256, DateTimeKind.Utc).AddTicks(8308), "tdp@gmail.com", true, null, false, null, "TDPAdmin", "TDP@GMAIL.COM", "TDPADMIN", "AQAAAAIAAYagAAAAENKXGDUc3IsPBZsJEj+uiAkOZrmTOO4Mve2VetfuLS2g4vZ7kFCBKOwlABW2ETlzbQ==", null, false, "27c6f783-8a19-425d-9208-c0ddb871d5ab", false, "TDPAdmin" }
                });

            migrationBuilder.InsertData(
                table: "DinesaurUser",
                columns: new[] { "Id", "Contact", "DinesaurUserID", "DinesaurUserName", "Email" },
                values: new object[] { 1, 91234568, "2", "User", "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "FoodID", "Category", "Cost", "Description", "FoodName", "Image", "MenuID", "StaffID" },
                values: new object[,]
                {
                    { 1, "Meat", 3.5, "White meat", "Chicken", "[]", 9999, "999" },
                    { 2, "Seafood", 4.0, "Saba", "Fish", "[]", 999, "9999" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "Category", "Catergories", "RestaurantID" },
                values: new object[,]
                {
                    { 1, "", "[]", 999 },
                    { 2, "", "[]", 9998 }
                });

            migrationBuilder.InsertData(
                table: "PreOrder",
                columns: new[] { "PreOrderID", "Cost", "MenuID", "Remarks", "ReservationID" },
                values: new object[,]
                {
                    { 1, 3.5, 1, "Please remove the onions", 1 },
                    { 2, 4.0, 2, "Please remove all vegetables", 2 }
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
                columns: new[] { "ReservationID", "CustomerID", "Date", "Pax", "Remarks", "RestaurantID", "ReviewID", "Status", "Time" },
                values: new object[,]
                {
                    { 1, "2", new DateTime(2026, 1, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, "N/A", 1, null, 1, new TimeOnly(12, 30, 0) },
                    { 2, "2", new DateTime(2026, 1, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "N/A", 1, null, 0, new TimeOnly(12, 30, 0) },
                    { 3, "2", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) },
                    { 4, "2", new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, "N/A", 1, null, 0, new TimeOnly(12, 30, 0) },
                    { 5, "2", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "N/A", 1, null, 1, new TimeOnly(12, 30, 0) },
                    { 6, "2", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) },
                    { 7, "2", new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) },
                    { 8, "2", new DateTime(2025, 12, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, "N/A", 1, null, 3, new TimeOnly(12, 30, 0) }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantID", "AdminID", "Category", "ClosingHours", "Contact", "CreatedAtUtc", "Email", "Location", "Logo", "OpeningHours", "RestaurantName", "RestaurantOwnerID", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Western", new TimeOnly(22, 0, 0), 82613992, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4616), "tomahawk@gmail.com", "273, #01-06 Thomson Rd, Novena Gardens, Singapore 307644", "[\"/Images/Tomahawk.jpeg\"]", new TimeOnly(12, 0, 0), "Tomahawk Contemporary Steakhouse", "3", 1 },
                    { 2, 1, "Fine Dining", new TimeOnly(21, 30, 0), 64121816, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4635), "ButcherBlock@gmail.com", "328 N Bridge Rd, #02-02 RAFFLES ARCADE, Singapore 188719", "[\"/Images/Butcher.jpg\"]", new TimeOnly(12, 0, 0), "Butcher's Block", "4", 1 },
                    { 3, 1, "HotPot", new TimeOnly(22, 30, 0), 88706606, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4640), "labula@gmail.com", "681 Punggol Dr., #01-07, Singapore 820681", "[\"/Images/LABULA.jpg\"]", new TimeOnly(10, 30, 0), "辣不辣 Labula Mala Sichuan Restaurant", "5", 1 },
                    { 4, 1, "Western", new TimeOnly(22, 0, 0), 94799101, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4644), "chefhats@gmail.com", "21 Hougang St 51, #01-01A Hougang GREEN Shopping Mall, Singapore 538719", "[\"/Images/Chef.jpg\"]", new TimeOnly(10, 0, 0), "Chef's Hats", "6", 0 },
                    { 5, 1, "Dessert", new TimeOnly(17, 30, 0), 94350556, new DateTime(2026, 1, 18, 6, 40, 55, 823, DateTimeKind.Utc).AddTicks(4648), "tdp@gmail.com", "406 Tampines Street 41, #01-23 Sun Plaza Green, Singapore 520406", "[\"/Images/tdp.jpeg\"]", new TimeOnly(11, 30, 0), "The Dessert Party", "7", 2 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewID", "CustomerID", "Date", "Description", "Rating", "RestaurantID", "ReviewTitle", "Status" },
                values: new object[] { 1, "2", new DateTime(2026, 1, 18, 14, 40, 55, 823, DateTimeKind.Local).AddTicks(4833), "Bad", 2.5, 1, "Bad", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "3", "4" },
                    { "3", "5" },
                    { "3", "6" },
                    { "3", "7" }
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
