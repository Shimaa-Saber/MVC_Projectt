using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0749a18c-980f-4fb3-8bd2-9184f1e7d77b");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Sessions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "desc",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "MakeUpServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MakeUpServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "priceRange",
                table: "Ateliers",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed5d8263-7a51-437e-8ce4-06ea6faa1793", 0, "b011e7a9-0b11-4d7c-8e8a-9c8d589e387f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJWCTUM9pjb5lsrVrxMr5dqiDVdM4Bx4v7L3gM/wM5PKYfKJTHMCvqQ0xEnkD0ilyQ==", "0123456789", true, "f29e2761-9c64-465c-8ae6-dab4398592c5", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "priceRange",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "priceRange",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "priceRange",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "priceRange",
                value: null);

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
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 7, 16, 48, 13, 405, DateTimeKind.Local).AddTicks(3964), "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Desc", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Location", "Name", "Price", "desc" },
                values: new object[] { "1.jpg", null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Location", "Name", "Price", "desc" },
                values: new object[] { "2.jpg", null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Location", "Name", "Price", "desc" },
                values: new object[] { "3.jpg", null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Location", "Name", "Price", "desc" },
                values: new object[] { "4.jpg", null, null, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2025, 4, 7, 16, 48, 13, 405, DateTimeKind.Local).AddTicks(3799), 1, 2, 1, 2, "Confirmed", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" },
                    { 4, 1, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "ed5d8263-7a51-437e-8ce4-06ea6faa1793" });

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed5d8263-7a51-437e-8ce4-06ea6faa1793");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "desc",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "MakeUpServices");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MakeUpServices");

            migrationBuilder.DropColumn(
                name: "priceRange",
                table: "Ateliers");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0749a18c-980f-4fb3-8bd2-9184f1e7d77b", 0, "55c67237-fae1-4887-8195-184d91a6eef4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELXXRUmPgzRcP2R/NTFWmmKf1g7vKeZEugKXN81rtTUPlCXtGDnpQ/27k++tUewdDw==", "0123456789", true, "21fb369f-a4b0-4a42-9d52-a8ca6106484d", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 22, 40, 9, 259, DateTimeKind.Local).AddTicks(2737), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 22, 40, 9, 259, DateTimeKind.Local).AddTicks(2900), "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });
        }
    }
}
