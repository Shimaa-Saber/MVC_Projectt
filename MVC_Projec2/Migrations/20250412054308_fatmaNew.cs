using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class fatmaNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "48cc6637-bbb3-4d63-bd89-f9c64603d2c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "6592980a-941b-44fa-82d8-7a545086c9a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48cc6637-bbb3-4d63-bd89-f9c64603d2c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6592980a-941b-44fa-82d8-7a545086c9a9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4b686451-182a-4c02-af05-f93cb15bb738", 0, "cbe91c93-b71c-4107-b245-5c32f6b2465c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDwzr9MwlVw9+HBag/gJXMQBj0yqWJ8LfY+RPtOpoBUdlWtqH9kwpLQuNqfGdiUYNQ==", "0123456789", true, "ddeb67ce-0761-4836-87b8-d03a3ead23f1", false, "admin@example.com" },
                    { "51a3f218-4855-4c7a-a775-59474274c3b1", 0, "127ef120-09a6-4beb-b952-aac8cba721fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFbv+HWyU3pX6CVi5q5qvPKNqz7FIzGjJdawldUZ0HXrMtcceoUuF9V60stCciWWlA==", "9876543210", true, "1600f1b0-f2e8-4270-a3a6-9c40323f00bf", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 43, 7, 528, DateTimeKind.Local).AddTicks(6217), "4b686451-182a-4c02-af05-f93cb15bb738" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "4b686451-182a-4c02-af05-f93cb15bb738");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 43, 7, 528, DateTimeKind.Local).AddTicks(6801), "4b686451-182a-4c02-af05-f93cb15bb738" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "4b686451-182a-4c02-af05-f93cb15bb738");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 43, 7, 528, DateTimeKind.Local).AddTicks(6883), "4b686451-182a-4c02-af05-f93cb15bb738" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "4b686451-182a-4c02-af05-f93cb15bb738" },
                    { "2", "51a3f218-4855-4c7a-a775-59474274c3b1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4b686451-182a-4c02-af05-f93cb15bb738" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "51a3f218-4855-4c7a-a775-59474274c3b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b686451-182a-4c02-af05-f93cb15bb738");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51a3f218-4855-4c7a-a775-59474274c3b1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48cc6637-bbb3-4d63-bd89-f9c64603d2c5", 0, "7b97963d-53b2-4dc4-9ae6-b424e3563735", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO5605WW4G0l05aTrkxdrL507P97bn9zyLcOoWgkY3uCwPlmx0AE+vcYPvELPBZxAw==", "9876543210", true, "fda115d5-f844-454c-97f3-824e927699e0", false, "user@example.com" },
                    { "6592980a-941b-44fa-82d8-7a545086c9a9", 0, "4e68fea1-1474-4c6a-a1cc-0946605bc785", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK1XmBFDsD5b1LKlweLcW7tpgrotfbnaqtJuHEr3CMsOkZEjDhxmgjqU4ley7eiTrw==", "0123456789", true, "7849f623-28a9-4867-a96b-df7cbaa1f94b", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 41, 51, 342, DateTimeKind.Local).AddTicks(6397), "6592980a-941b-44fa-82d8-7a545086c9a9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "6592980a-941b-44fa-82d8-7a545086c9a9");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 41, 51, 342, DateTimeKind.Local).AddTicks(6648), "6592980a-941b-44fa-82d8-7a545086c9a9" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "6592980a-941b-44fa-82d8-7a545086c9a9");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 7, 41, 51, 342, DateTimeKind.Local).AddTicks(6906), "6592980a-941b-44fa-82d8-7a545086c9a9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "48cc6637-bbb3-4d63-bd89-f9c64603d2c5" },
                    { "1", "6592980a-941b-44fa-82d8-7a545086c9a9" }
                });
        }
    }
}
