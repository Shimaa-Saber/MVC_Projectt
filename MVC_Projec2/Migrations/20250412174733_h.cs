using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class h : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "65e3629a-d0b9-4dab-93d5-d772353a039a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "c9ab8252-c86b-4e09-8b94-5e106299d156" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65e3629a-d0b9-4dab-93d5-d772353a039a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9ab8252-c86b-4e09-8b94-5e106299d156");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e665a52-78d3-42b0-8eac-6269ab09b86b", 0, "7ac8d221-8781-4965-b172-f6ac30baf453", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFQ2tsWJ5BguWF1B5TChb2WQetVpJ3GSu0ZrK2fRqq8ZcXhL/3kbojGLnl4ISdwSvw==", "9876543210", true, "096092dd-0582-4a64-afaa-bf3d73b43989", false, "user@example.com" },
                    { "7273d2b5-13ce-4e50-ad9f-9261149bdd6f", 0, "96904a68-f726-4edc-b8d9-61a65d5ba466", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKyMZUl/P1ynAlDOa2EjgnSll5uKztkHAg1hcpneySfXBCZEDTanru6T9Anw3tU09A==", "0123456789", true, "a9540812-242a-40c4-b6bb-580b9334de1c", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "Atelier (1).jpeg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "Atelier (2).jpeg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "Atelier (3).jpeg");

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 13, 5, "Atelier (21).jpeg" },
                    { 14, 5, "Atelier (22).jpeg" },
                    { 15, 5, "Atelier (23).jpeg" },
                    { 16, 6, "Atelier (24).jpeg" },
                    { 17, 6, "Atelier (25).jpeg" },
                    { 18, 6, "Atelier (26).jpeg" },
                    { 19, 7, "Atelier (27).jpeg" },
                    { 20, 7, "Atelier (28).jpeg" },
                    { 21, 7, "Atelier (29).jpeg" },
                    { 22, 7, "Atelier (4).jpeg" },
                    { 23, 8, "Atelier (5).jpeg" },
                    { 24, 8, "Atelier (6).jpeg" },
                    { 25, 8, "Atelier (7).jpeg" },
                    { 26, 9, "Atelier (8).jpeg" },
                    { 27, 9, "Atelier (9).jpeg" },
                    { 28, 9, "Atelier (10).jpeg" },
                    { 29, 10, "Atelier (11).jpeg" },
                    { 30, 10, "Atelier (12).jpeg" },
                    { 31, 10, "Atelier (13).jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "ImageUrl", "Location", "Name", "priceRange" },
                values: new object[,]
                {
                    { 11, "Atelier (20).jpeg", "Central Square", "Style Studio", 1500.0 },
                    { 12, "Atelier (21).jpeg", "Central Square", "Elegance Edge", 5500.0 },
                    { 13, "Atelier (22).jpeg", "Central Square", "Vogue Venue", 2400.0 },
                    { 14, "Atelier (23).jpeg", "Central Square", "Chic Charm", 8200.0 },
                    { 15, "Atelier (24).jpeg", "Central Square", "Glamour Gate", 4300.0 },
                    { 16, "Atelier (25).jpeg", "Central Square", "Runway Room", 4200.0 },
                    { 17, "Atelier (26).jpeg", "Central Square", "Trendy Touch", 3500.0 },
                    { 18, "Atelier (27).jpeg", "Central Square", "Haute Hub", 2900.0 },
                    { 19, "Atelier (28).jpeg", "Central Square", "Modish Moments", 4400.0 },
                    { 20, "Atelier (29).jpeg", "Central Square", "Catwalk Corner", 1100.0 }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 47, 32, 438, DateTimeKind.Local).AddTicks(9960), "7273d2b5-13ce-4e50-ad9f-9261149bdd6f" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "7273d2b5-13ce-4e50-ad9f-9261149bdd6f");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 47, 32, 439, DateTimeKind.Local).AddTicks(271), "7273d2b5-13ce-4e50-ad9f-9261149bdd6f" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "7273d2b5-13ce-4e50-ad9f-9261149bdd6f");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 47, 32, 439, DateTimeKind.Local).AddTicks(327), "7273d2b5-13ce-4e50-ad9f-9261149bdd6f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "5e665a52-78d3-42b0-8eac-6269ab09b86b" },
                    { "1", "7273d2b5-13ce-4e50-ad9f-9261149bdd6f" }
                });

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 32, 11, "Atelier (14).jpeg" },
                    { 33, 11, "Atelier (15).jpeg" },
                    { 34, 11, "Atelier (16).jpeg" },
                    { 35, 12, "Atelier (17).jpeg" },
                    { 36, 12, "Atelier (18).jpeg" },
                    { 37, 12, "Atelier (19).jpeg" },
                    { 38, 13, "Atelier (1).jpeg" },
                    { 39, 13, "Atelier (5).jpeg" },
                    { 40, 13, "Atelier (9).jpeg" },
                    { 41, 14, "Atelier (20).jpeg" },
                    { 42, 14, "Atelier (15).jpeg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "5e665a52-78d3-42b0-8eac-6269ab09b86b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "7273d2b5-13ce-4e50-ad9f-9261149bdd6f" });

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e665a52-78d3-42b0-8eac-6269ab09b86b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7273d2b5-13ce-4e50-ad9f-9261149bdd6f");

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65e3629a-d0b9-4dab-93d5-d772353a039a", 0, "23f2dac8-8471-4c96-88a7-93a914a29d53", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAENENNFMOKkyi25jWlfYdNfyBn1AyIFTdOZ12rdhM+dyywDLE+f7rZEZKYlvgS6oC/w==", "9876543210", true, "47d60c33-d809-44ab-84dd-e2bad0895f93", false, "user@example.com" },
                    { "c9ab8252-c86b-4e09-8b94-5e106299d156", 0, "b1d1afbf-8bae-455d-9ed0-cb75a199d4d1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH+T/9oFfr1VOT7Hhr8J7dsV6lyK/AadJu/qYHb0JT0gpE3q3L0Mhcw86t3DdRtU6Q==", "0123456789", true, "ea18e68c-39c1-4e26-b7f6-e3f08ec24cfa", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "Atelier (23).jpeg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "Atelier (22).jpeg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "Atelier (21).jpeg");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 27, 56, 729, DateTimeKind.Local).AddTicks(5885), "c9ab8252-c86b-4e09-8b94-5e106299d156" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "c9ab8252-c86b-4e09-8b94-5e106299d156");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 27, 56, 729, DateTimeKind.Local).AddTicks(6078), "c9ab8252-c86b-4e09-8b94-5e106299d156" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "c9ab8252-c86b-4e09-8b94-5e106299d156");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 27, 56, 729, DateTimeKind.Local).AddTicks(6145), "c9ab8252-c86b-4e09-8b94-5e106299d156" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "65e3629a-d0b9-4dab-93d5-d772353a039a" },
                    { "1", "c9ab8252-c86b-4e09-8b94-5e106299d156" }
                });
        }
    }
}
