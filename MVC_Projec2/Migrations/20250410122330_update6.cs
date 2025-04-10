using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1f51c268-9039-4109-a816-6fd3b884d3fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f51c268-9039-4109-a816-6fd3b884d3fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f45d3b1-6fab-45f9-9b36-c0ba9c736145");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Ateliers");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Ateliers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c8e3562a-98ae-4cbf-8aa2-21ee1131991d", 0, "e5b8941e-7628-4437-86a4-eb4711079585", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOdgrKjbBI/p8Q7MIB5dT2fYAhv1LZ9RCiCeKopfTvdEj9UfrONTPrY7mdBoc85ZpA==", "0123456789", true, "d26dcaef-30cf-4493-a4d7-a2e92c2691d1", false, "admin@example.com" },
                    { "f3699628-dff8-4036-b9e7-130c304606de", 0, "6ce8c4ee-03b7-46b5-805b-7de75091f8b7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB3hlCedfbBdgnf3Ki/I10IcyUN8rXA+Hm8qEgW+nGvs4KR8W3ydLvfMCqYUKqlA3A==", "9876543210", true, "39dd9e8b-abc2-4408-9e16-944e4d2bf8ab", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 23, 29, 439, DateTimeKind.Local).AddTicks(5755), "c8e3562a-98ae-4cbf-8aa2-21ee1131991d" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "c8e3562a-98ae-4cbf-8aa2-21ee1131991d");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 23, 29, 439, DateTimeKind.Local).AddTicks(5966), "c8e3562a-98ae-4cbf-8aa2-21ee1131991d" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "c8e3562a-98ae-4cbf-8aa2-21ee1131991d");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 23, 29, 439, DateTimeKind.Local).AddTicks(6041), "c8e3562a-98ae-4cbf-8aa2-21ee1131991d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "c8e3562a-98ae-4cbf-8aa2-21ee1131991d" },
                    { "2", "f3699628-dff8-4036-b9e7-130c304606de" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "c8e3562a-98ae-4cbf-8aa2-21ee1131991d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "f3699628-dff8-4036-b9e7-130c304606de" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8e3562a-98ae-4cbf-8aa2-21ee1131991d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3699628-dff8-4036-b9e7-130c304606de");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Ateliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f51c268-9039-4109-a816-6fd3b884d3fe", 0, "cd1943e0-a09d-4d50-9d76-136b267b9226", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBH7apUbYTO2pZBXDRyf/QWlFL1uJjoFPBr+SHTUn7YHiIQzm4Qs92ou0/gKJBuV5A==", "9876543210", true, "737108ad-29a6-4f97-88bc-61d902202701", false, "user@example.com" },
                    { "2f45d3b1-6fab-45f9-9b36-c0ba9c736145", 0, "e12d3492-81e2-4aa5-950f-5d157c1cbbbd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELP4DRd/2FbTIHuPLLnjrriLPxv1Yl9yzKiA7sFEBoI+x/wNvg0aI2flefuQIn7FJw==", "0123456789", true, "5e65a52c-c1d4-42b8-8107-b3bca99ee3a5", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "IsAvailable" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageURL", "IsAvailable" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "IsAvailable" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "IsAvailable" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(458), "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "2f45d3b1-6fab-45f9-9b36-c0ba9c736145");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(659), "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "2f45d3b1-6fab-45f9-9b36-c0ba9c736145");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(805), "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "1f51c268-9039-4109-a816-6fd3b884d3fe" },
                    { "1", "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" }
                });
        }
    }
}
