using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1643b6a6-52b2-44a0-9758-004c6a6e717e");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Halls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Halls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Halls",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Decors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Decors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c605afc-c225-4ef8-989c-643648088c83", 0, "2d74a726-e0b7-4513-9b35-051d49fe405b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBRMTQA491UyuK3UbrQU+0y7XnUuAGv6giBgkzaGYcr58wuUNzV96unSe59NmMlsVA==", "0123456789", true, "580edb5c-86c6-4f1e-a948-01aa077f9c38", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 55, 41, 476, DateTimeKind.Local).AddTicks(9339), "0c605afc-c225-4ef8-989c-643648088c83" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "0c605afc-c225-4ef8-989c-643648088c83" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 17, 55, 41, 476, DateTimeKind.Local).AddTicks(9592), "0c605afc-c225-4ef8-989c-643648088c83" });

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Location", "Price" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Location", "Price" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "Price" },
                values: new object[] { null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "0c605afc-c225-4ef8-989c-643648088c83" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0c605afc-c225-4ef8-989c-643648088c83" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c605afc-c225-4ef8-989c-643648088c83");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Decors");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Decors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1643b6a6-52b2-44a0-9758-004c6a6e717e", 0, "73b7bebe-dcde-4e01-a897-f39ff576d3c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFiBChZ5LrlEnVMKlDXNDAZQ828nh9HueYvddRrif4AS4jxEs1rl8yrHOz6bDECxag==", "0123456789", true, "ebbea584-c284-48c4-a37a-da96f480c45c", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(137), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(328), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1643b6a6-52b2-44a0-9758-004c6a6e717e" });
        }
    }
}
