using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class h2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5e874efa-183d-401a-8c5a-022015c455b3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "c1218f34-5729-4831-bd12-88bf2e810d96" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e874efa-183d-401a-8c5a-022015c455b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1218f34-5729-4831-bd12-88bf2e810d96");

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
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "Atelier (20).jpeg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "atelier2.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "atelier1.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "atelier5.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "atelier3.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "atelier4.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "atelier7.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "atelier5.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "atelier1.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "Atelier (3).jpeg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "Atelier (19).jpeg");

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

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decor2.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "decor2.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "decor4.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "decor1.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "decor2.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "decor3.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "decor4.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "decor5.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "decor1.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decor3.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "decor6.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "decor5.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "decor2.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "Hall (5).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "Hall (6).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "Hall (7).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "Hall (8).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "Hall (9).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "Hall (10).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "Hall (11).jpeg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "Hall (12).jpeg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "hall1.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "hall2.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "hall3.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "hall4.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "Hall (5).jpeg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "hall1.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "hall2.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "hall3.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "hall4.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "hall3.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "MakeUp (1).jpeg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "MakeUp (2).jpeg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "MakeUp (3).jpeg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "MakeUp (4).jpeg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "makeUp1.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "makeUp2.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "makeUp3.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "makeUp4.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "makeUp5.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "makeUp6.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "makeUp7.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "makeUp8.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "MakeUp (9).jpeg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "MakeUp (10).jpeg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "session8.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "session1.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "session2.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "session3.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "session4.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "session5.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "session6.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "session7.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "session8.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "session9.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session3.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "65e3629a-d0b9-4dab-93d5-d772353a039a" },
                    { "1", "c9ab8252-c86b-4e09-8b94-5e106299d156" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5e874efa-183d-401a-8c5a-022015c455b3", 0, "98f0011e-460a-46a6-8980-971ac9f9e403", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIjPWS33UVnWipxUdVMNP6F19drNPgi1eY8x7T4n1x1bbhhyHLmoBWIrAJAdg1LeNQ==", "0123456789", true, "0240fead-9644-482f-a19c-8cc6fc88e866", false, "admin@example.com" },
                    { "c1218f34-5729-4831-bd12-88bf2e810d96", 0, "d9aa8688-f927-4ec8-9f9d-a6342e53b373", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEBrbuCxSQINinDsXTB45brtlosdEKL0+G+GJ2GNw0XQCIcHZAhfh0GE1sYIEBWiaQ==", "9876543210", true, "87796a7a-23b0-4ea8-bc0b-40bc958969cd", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "atelier8.jpg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "atelier9.jpg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "atelier10.jpg");

            migrationBuilder.UpdateData(
                table: "AtelierImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "atelier8.jpg");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "atelier2");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "atelier1");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "atelier5");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "atelier3");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "atelier4");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "atelier7");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "atelier5");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "atelier1");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "atelier5");

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "atelier7");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 51, 57, 880, DateTimeKind.Local).AddTicks(2817), "5e874efa-183d-401a-8c5a-022015c455b3" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "5e874efa-183d-401a-8c5a-022015c455b3");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 51, 57, 880, DateTimeKind.Local).AddTicks(2963), "5e874efa-183d-401a-8c5a-022015c455b3" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "5e874efa-183d-401a-8c5a-022015c455b3");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 12, 1, 51, 57, 880, DateTimeKind.Local).AddTicks(3035), "5e874efa-183d-401a-8c5a-022015c455b3" });

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decor7.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "decor7.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "decor7.jpg");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "decor1");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "decor2");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "decor3");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "decor4");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "decor5");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "decor1");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decor3");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "decor6");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "decor5");

            migrationBuilder.UpdateData(
                table: "Decors",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "decor2");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "hall5.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "hall6.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "hall7.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "hall8.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "hall9.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "hall10.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "hall5.jpg");

            migrationBuilder.UpdateData(
                table: "HallImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "hall3.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "hall1");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "hall2");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "hall3");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "hall4");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "hall5");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "hall1");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "hall2");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "hall3");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "hall4");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "hall3");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "makeUp9.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "makeUp10.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "makeUp2.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "makeUp7.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "makeUp1");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "makeUp2");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "makeUp3");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "makeUp4");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "makeUp5");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "makeUp6");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "makeUp7");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "makeUp8");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "makeUp9");

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "makeUp10");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session10.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "session1.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "session1");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "session2");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "session3");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "session4");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "session5");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "session6");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "session7");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "session8");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "session9");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session10");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "5e874efa-183d-401a-8c5a-022015c455b3" },
                    { "2", "c1218f34-5729-4831-bd12-88bf2e810d96" }
                });
        }
    }
}
