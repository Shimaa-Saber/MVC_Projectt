using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class hager2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Ateliers_AtelierId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Decors_DecorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Halls_HallId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MakeUpServices_MakeUpServiceId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sessions_SessionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_DecoreImages_Decors_DecorId",
                table: "DecoreImages");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AtelierId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DecorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_HallId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MakeUpServiceId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_SessionId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DecoreImages",
                table: "DecoreImages");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46");

            migrationBuilder.DropColumn(
                name: "AtelierId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MakeUpServiceId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "DecoreImages",
                newName: "DecoreImage");

            migrationBuilder.RenameIndex(
                name: "IX_DecoreImages_DecorId",
                table: "DecoreImage",
                newName: "IX_DecoreImage_DecorId");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceType",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DecoreImage",
                table: "DecoreImage",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AtelierImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtelierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtelierImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtelierImages_Ateliers_AtelierId",
                        column: x => x.AtelierId,
                        principalTable: "Ateliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeUpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpImages_MakeUpServices_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionImages_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "35d44107-5eee-47d4-b117-e93072e80f89", 0, "10e02d0c-0126-4160-ae6f-f25ec6252202", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIsjySaaa9LtoezwL26PcguIR0Oyh79/43o5hoLz64izBOYdDJq9TNj1+rqF8KHx+g==", "0123456789", true, "22f5c299-9448-40bc-808e-cf2277c8d25e", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "atelier1.jpg" },
                    { 2, 2, "atelier2.jpg" },
                    { 3, 3, "atelier3.jpg" },
                    { 4, 4, "atelier4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 5, "North Park", "Chic Styles" },
                    { 6, "South Side", "Vintage Touch" },
                    { 7, "Midtown", "Modern Artistry" },
                    { 8, "East End", "Exquisite Design" },
                    { 9, "West End", "Timeless Beauty" },
                    { 10, "Central Square", "Fashion Forward" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 47, 34, 46, DateTimeKind.Local).AddTicks(3351), "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ServiceId", "ServiceType", "UserId" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 47, 34, 46, DateTimeKind.Local).AddTicks(3671), 0, 0, "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.InsertData(
                table: "DecoreImage",
                columns: new[] { "Id", "DecorId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "decore1.jpg" },
                    { 2, 2, "decore2.jpg" },
                    { 3, 3, "decore3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Decors",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Style" },
                values: new object[,]
                {
                    { 4, null, null, 5500, "Vintage" },
                    { 5, null, null, 6000, "Industrial" },
                    { 6, null, null, 4000, "Boho" },
                    { 7, null, null, 6500, "Minimalist" },
                    { 8, null, null, 7000, "Art Deco" },
                    { 9, null, null, 8000, "Glam" },
                    { 10, null, null, 4500, "Shabby Chic" }
                });

            migrationBuilder.InsertData(
                table: "HallImages",
                columns: new[] { "Id", "HallId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "hall1.jpg" },
                    { 2, 2, "hall2.jpg" },
                    { 3, 3, "hall3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "ImageUrl", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 400, "6.jpg", null, "Majestic Hall", null },
                    { 5, 350, "7.jpg", null, "Ocean View", null },
                    { 6, 600, "8.jpg", null, "Skyline Pavilion", null },
                    { 7, 250, "9.jpg", null, "Moonlight Hall", null },
                    { 8, 450, "10.jpg", null, "Royal Suite", null },
                    { 9, 500, "11.jpg", null, "Elite Venue", null },
                    { 10, 700, "12.jpg", null, "Luxury Retreat", null }
                });

            migrationBuilder.InsertData(
                table: "MakeUpImages",
                columns: new[] { "Id", "ImageUrl", "MakeUpId" },
                values: new object[,]
                {
                    { 1, "makeup1.jpg", 1 },
                    { 2, "makeup2.jpg", 2 },
                    { 3, "makeup3.jpg", 3 },
                    { 4, "makeup4.jpg", 4 }
                });

            migrationBuilder.InsertData(
                table: "MakeUpServices",
                columns: new[] { "Id", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 5, null, "Glamour Shine", 1200 },
                    { 6, null, "Festival Glam", 700 },
                    { 7, null, "Bridal Glow", 1600 },
                    { 8, null, "Special Occasion", 1300 },
                    { 9, null, "Celebrity Look", 2000 },
                    { 10, null, "Simple Elegance", 600 }
                });

            migrationBuilder.InsertData(
                table: "SessionImages",
                columns: new[] { "Id", "ImageUrl", "SessionId" },
                values: new object[,]
                {
                    { 1, "session1_1.jpg", 1 },
                    { 2, "session2_1.jpg", 2 },
                    { 3, "session3_1.jpg", 3 },
                    { 4, "session4_1.jpg", 4 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Duration", "ImageUrl", "Type" },
                values: new object[,]
                {
                    { 5, 6, "5.jpg", "Wedding Photography" },
                    { 6, 2, "6.jpg", "Couple Shoot" },
                    { 7, 3, "7.jpg", "Bridal Portraits" },
                    { 8, 4, "8.jpg", "Fashion Photography" },
                    { 9, 5, "9.jpg", "Event Coverage" },
                    { 10, 3, "10.jpg", "Family Shoot" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 5, 5, "atelier5.jpg" },
                    { 6, 6, "atelier6.jpg" },
                    { 7, 7, "atelier7.jpg" },
                    { 8, 8, "atelier8.jpg" },
                    { 9, 9, "atelier9.jpg" },
                    { 10, 10, "atelier10.jpg" }
                });

            migrationBuilder.InsertData(
                table: "DecoreImage",
                columns: new[] { "Id", "DecorId", "ImageUrl" },
                values: new object[,]
                {
                    { 4, 4, "decore4.jpg" },
                    { 5, 5, "decore5.jpg" },
                    { 6, 6, "decore6.jpg" },
                    { 7, 7, "decore7.jpg" },
                    { 8, 8, "decore8.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HallImages",
                columns: new[] { "Id", "HallId", "ImageUrl" },
                values: new object[,]
                {
                    { 4, 4, "hall4.jpg" },
                    { 5, 5, "hall5.jpg" },
                    { 6, 6, "hall6.jpg" },
                    { 7, 7, "hall7.jpg" },
                    { 8, 8, "hall8.jpg" },
                    { 9, 9, "hall9.jpg" },
                    { 10, 10, "hall10.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MakeUpImages",
                columns: new[] { "Id", "ImageUrl", "MakeUpId" },
                values: new object[,]
                {
                    { 5, "makeup5.jpg", 5 },
                    { 6, "makeup6.jpg", 6 },
                    { 7, "makeup7.jpg", 7 },
                    { 8, "makeup8.jpg", 8 },
                    { 9, "makeup9.jpg", 9 },
                    { 10, "makeup10.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "SessionImages",
                columns: new[] { "Id", "ImageUrl", "SessionId" },
                values: new object[,]
                {
                    { 5, "session5_1.jpg", 5 },
                    { 6, "session6_1.jpg", 6 },
                    { 7, "session7_1.jpg", 7 },
                    { 8, "session8_1.jpg", 8 },
                    { 9, "session9_1.jpg", 9 },
                    { 10, "session10_1.jpg", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtelierImages_AtelierId",
                table: "AtelierImages",
                column: "AtelierId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpImages_MakeUpId",
                table: "MakeUpImages",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionImages_SessionId",
                table: "SessionImages",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DecoreImage_Decors_DecorId",
                table: "DecoreImage",
                column: "DecorId",
                principalTable: "Decors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DecoreImage_Decors_DecorId",
                table: "DecoreImage");

            migrationBuilder.DropTable(
                name: "AtelierImages");

            migrationBuilder.DropTable(
                name: "MakeUpImages");

            migrationBuilder.DropTable(
                name: "SessionImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DecoreImage",
                table: "DecoreImage");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35d44107-5eee-47d4-b117-e93072e80f89");

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "DecoreImage",
                newName: "DecoreImages");

            migrationBuilder.RenameIndex(
                name: "IX_DecoreImage_DecorId",
                table: "DecoreImages",
                newName: "IX_DecoreImages_DecorId");

            migrationBuilder.AddColumn<int>(
                name: "AtelierId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DecorId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HallId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeUpServiceId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DecoreImages",
                table: "DecoreImages",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46", 0, "084eba3e-49f6-4bc0-97fb-2013437699ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPUWAGOHi/TN55c9PR7Ux5iej5fIgX1iPMSGy1Te0M+st1hR0yPxXYrQ9QEt98sSCw==", "0123456789", true, "ebfb4d2c-bdbf-4019-9e7d-b649f456e23f", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(6052), "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtelierId", "CreatedAt", "DecorId", "HallId", "MakeUpServiceId", "SessionId", "UserId" },
                values: new object[] { 3, new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(6173), 1, 2, 1, 2, "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(5866), 1, 2, 1, 1, "Confirmed", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" },
                    { 2, 1, new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AtelierId",
                table: "Comments",
                column: "AtelierId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DecorId",
                table: "Comments",
                column: "DecorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HallId",
                table: "Comments",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MakeUpServiceId",
                table: "Comments",
                column: "MakeUpServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SessionId",
                table: "Comments",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Ateliers_AtelierId",
                table: "Comments",
                column: "AtelierId",
                principalTable: "Ateliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Decors_DecorId",
                table: "Comments",
                column: "DecorId",
                principalTable: "Decors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Halls_HallId",
                table: "Comments",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MakeUpServices_MakeUpServiceId",
                table: "Comments",
                column: "MakeUpServiceId",
                principalTable: "MakeUpServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sessions_SessionId",
                table: "Comments",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DecoreImages_Decors_DecorId",
                table: "DecoreImages",
                column: "DecorId",
                principalTable: "Decors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
