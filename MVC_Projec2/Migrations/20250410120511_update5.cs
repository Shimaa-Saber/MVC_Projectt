using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "e24c41d0-25ec-436d-b777-b115e6d5fec8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46206c1e-5e42-453b-ae03-481b21d659a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e24c41d0-25ec-436d-b777-b115e6d5fec8");

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
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

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
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "2f45d3b1-6fab-45f9-9b36-c0ba9c736145" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "46206c1e-5e42-453b-ae03-481b21d659a9", 0, "9be4640a-7568-44cd-af86-975685a9fd3b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAECb2akT6eV6CNzAl8QYf/9GxVUyjz8wJA8Rbu9SYfIviVQaeaOSW5dPWyxOGviJECw==", "0123456789", true, "01deb3e5-822d-4d61-83e1-9bc9d29c23e0", false, "admin@example.com" },
                    { "e24c41d0-25ec-436d-b777-b115e6d5fec8", 0, "63193402-30dd-4f30-b5d5-f4d2b4956dc6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFyGkB+iAQVuomuFqYOreCaPsvensuAB/tPuDneZcgNoJD2Jp1K7Pf2a9G0kJ57uVA==", "9876543210", true, "58c6d9a2-8c56-419b-a666-630eb73102ae", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 6, 35, 657, DateTimeKind.Local).AddTicks(4895), "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 6, 35, 657, DateTimeKind.Local).AddTicks(5145), "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 17, 6, 35, 657, DateTimeKind.Local).AddTicks(5568), "46206c1e-5e42-453b-ae03-481b21d659a9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "46206c1e-5e42-453b-ae03-481b21d659a9" },
                    { "2", "e24c41d0-25ec-436d-b777-b115e6d5fec8" }
                });
        }
    }
}
