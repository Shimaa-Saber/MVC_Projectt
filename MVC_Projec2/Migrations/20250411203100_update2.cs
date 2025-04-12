using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "82074630-fe2b-4689-8c51-ab5a48732036" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "b20c409c-e1ff-4b34-b7af-477e4a443768" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82074630-fe2b-4689-8c51-ab5a48732036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b20c409c-e1ff-4b34-b7af-477e4a443768");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Halls",
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
                column: "user_id",
                value: "d969659c-3aeb-4360-9a03-c2129fbd05fc");

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
                column: "user_id",
                value: "d969659c-3aeb-4360-9a03-c2129fbd05fc");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 11, 22, 30, 58, 714, DateTimeKind.Local).AddTicks(6028), "d969659c-3aeb-4360-9a03-c2129fbd05fc" });

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

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

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Decors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82074630-fe2b-4689-8c51-ab5a48732036", 0, "1ffd82fc-a946-4297-8b29-50d1833d5295", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENKv1sPw/2QZ9PHQKszrg1L5haAAHBs3YyobTNkt1rZ3yYna3g2vNu8GGL+PcHez2g==", "0123456789", true, "4eb97bb1-e94a-46ca-8ee6-af9d3a3cf9d9", false, "admin@example.com" },
                    { "b20c409c-e1ff-4b34-b7af-477e4a443768", 0, "9f110e21-614e-4c06-a284-bcdb9cabed38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGsC29wLucp811HTH8EeL02OcaZDgAUKqVc7q07KJG8SMUPq839R2t4i3y2jOOv8zw==", "9876543210", true, "a0c4c242-b81b-4798-aa95-d37c1181a014", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(3456), "82074630-fe2b-4689-8c51-ab5a48732036" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "82074630-fe2b-4689-8c51-ab5a48732036");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(3780), "82074630-fe2b-4689-8c51-ab5a48732036" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "82074630-fe2b-4689-8c51-ab5a48732036");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(4282), "82074630-fe2b-4689-8c51-ab5a48732036" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "82074630-fe2b-4689-8c51-ab5a48732036" },
                    { "2", "b20c409c-e1ff-4b34-b7af-477e4a443768" }
                });
        }
    }
}
