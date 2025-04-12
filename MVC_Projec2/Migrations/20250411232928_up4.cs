using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class up4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "d8a814c4-b7fc-4e6b-abaf-1b71bd7ad9c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8a814c4-b7fc-4e6b-abaf-1b71bd7ad9c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d969659c-3aeb-4360-9a03-c2129fbd05fc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20825a0f-7b3e-46b6-8880-271eac074c8e", 0, "665b2367-d37f-4e80-aba8-49d141785c60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJCTJmoikiDCYpl0VblLis7fYN7g1rz+d+mfwCslDWZOJpVbmjkmumL0jr67d/TPZQ==", "9876543210", true, "ae7ddc9a-11f4-4013-913c-f85dd91f0b89", false, "user@example.com" },
                    { "915f09d1-f412-4330-b6cf-858d7657b54d", 0, "e9e9bffd-7450-472c-8e4f-92e4d980c58c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBO55+ph9vjwtkScwr6pNUoN3V1nz9NgHz8AjLLl5paYFD0z8yhxQI0O29DEUZMmhw==", "0123456789", true, "daa6ca08-8ebf-4f80-b76b-85e227f74f96", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 29, 26, 646, DateTimeKind.Local).AddTicks(1493), "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 29, 26, 646, DateTimeKind.Local).AddTicks(1642), "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 29, 26, 646, DateTimeKind.Local).AddTicks(1703), "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "makeUp1.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "20825a0f-7b3e-46b6-8880-271eac074c8e" },
                    { "1", "915f09d1-f412-4330-b6cf-858d7657b54d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "20825a0f-7b3e-46b6-8880-271eac074c8e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "915f09d1-f412-4330-b6cf-858d7657b54d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20825a0f-7b3e-46b6-8880-271eac074c8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "915f09d1-f412-4330-b6cf-858d7657b54d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d8a814c4-b7fc-4e6b-abaf-1b71bd7ad9c2", 0, "0518a97c-17a3-4cd6-b453-c9b266de1df1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP3iQ7d7dfwJX/Vo5MyyASISLEACVBPU0QpQdv8LAV32BAl7vEkF2QqWG5w1uMoUDA==", "9876543210", true, "2337e7e4-4fea-4b9f-848e-af06f7e6d7e6", false, "user@example.com" },
                    { "d969659c-3aeb-4360-9a03-c2129fbd05fc", 0, "8eb31c39-9c88-4dcc-bc0a-b55aaeb0b380", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHlcV0SM3m06IWFVT1GvYaTOVjUGhS7M7THP2spHw6KN/Hf1DNrfpbwXMHENFw8vVA==", "0123456789", true, "bc35e006-3f82-4481-9ea5-e031771961f2", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 22, 30, 58, 714, DateTimeKind.Local).AddTicks(5905), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 22, 30, 58, 714, DateTimeKind.Local).AddTicks(5998), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 11, 22, 30, 58, 714, DateTimeKind.Local).AddTicks(6028), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "d8a814c4-b7fc-4e6b-abaf-1b71bd7ad9c2" },
                    { "1", "d969659c-3aeb-4360-9a03-c2129fbd05fc" }
                });
        }
    }
}
