using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class hager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "b749d298-6f7e-435c-b2a2-cfe028b18134" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b749d298-6f7e-435c-b2a2-cfe028b18134");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0749a18c-980f-4fb3-8bd2-9184f1e7d77b", 0, "55c67237-fae1-4887-8195-184d91a6eef4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELXXRUmPgzRcP2R/NTFWmmKf1g7vKeZEugKXN81rtTUPlCXtGDnpQ/27k++tUewdDw==", "0123456789", true, "21fb369f-a4b0-4a42-9d52-a8ca6106484d", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 40, 34, 31, DateTimeKind.Local).AddTicks(7144), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 40, 34, 31, DateTimeKind.Local).AddTicks(7307), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0749a18c-980f-4fb3-8bd2-9184f1e7d77b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b749d298-6f7e-435c-b2a2-cfe028b18134", 0, "46256405-b680-4ffc-9401-b0fc174b23ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEItbLAfKlIfbeLT32yn/qQMWArhJZw1g1fdP/1u85h3pI+c0vgpG5AmWhiMsF+K9AQ==", "0123456789", true, "bb16f6bd-dd8f-41b0-a1b2-a215897aa92d", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 22, 40, 9, 259, DateTimeKind.Local).AddTicks(2737), "b749d298-6f7e-435c-b2a2-cfe028b18134" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "b749d298-6f7e-435c-b2a2-cfe028b18134" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 22, 40, 9, 259, DateTimeKind.Local).AddTicks(2900), "b749d298-6f7e-435c-b2a2-cfe028b18134" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "b749d298-6f7e-435c-b2a2-cfe028b18134" });
        }
    }
}
