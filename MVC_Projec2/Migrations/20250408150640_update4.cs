using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed5d8263-7a51-437e-8ce4-06ea6faa1793");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed5d8263-7a51-437e-8ce4-06ea6faa1793", 0, "b011e7a9-0b11-4d7c-8e8a-9c8d589e387f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJWCTUM9pjb5lsrVrxMr5dqiDVdM4Bx4v7L3gM/wM5PKYfKJTHMCvqQ0xEnkD0ilyQ==", "0123456789", true, "f29e2761-9c64-465c-8ae6-dab4398592c5", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 48, 13, 405, DateTimeKind.Local).AddTicks(3558), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 48, 13, 405, DateTimeKind.Local).AddTicks(3799), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 48, 13, 405, DateTimeKind.Local).AddTicks(3964), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });
        }
    }
}
