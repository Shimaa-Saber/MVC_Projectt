using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class hager5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35d44107-5eee-47d4-b117-e93072e80f89");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Decors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5d2340c0-fe48-444e-9eb8-c21a10342a32", 0, "42e3164d-3aeb-4d1d-9248-b19d0536d064", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEImm+icPFxrPO880YjZ3ahav438qnCS6xdDCgGbIunzYPwqp05NocjF9bTLKusrQzA==", "0123456789", true, "897e17c8-b434-46c0-a951-98ab06b99d87", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 0, 17, 4, 658, DateTimeKind.Local).AddTicks(5721), "5d2340c0-fe48-444e-9eb8-c21a10342a32" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "5d2340c0-fe48-444e-9eb8-c21a10342a32" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 10, 0, 17, 4, 658, DateTimeKind.Local).AddTicks(5892), "5d2340c0-fe48-444e-9eb8-c21a10342a32" });

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "decor1.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "decor2.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "decor3.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "decor4.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "decor5.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "decor6.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decor7.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "decor8.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "makeUp1.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "makeUp2.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "makeUp3.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "makeUp4.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "makeUp5.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "makeUp6.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "makeUp7.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "makeUp8.jpg");

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
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "session1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "session2.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "session3.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "session4.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "session5.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "session6.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "session7.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "session8.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "session9.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session10.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "5d2340c0-fe48-444e-9eb8-c21a10342a32" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5d2340c0-fe48-444e-9eb8-c21a10342a32" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d2340c0-fe48-444e-9eb8-c21a10342a32");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "35d44107-5eee-47d4-b117-e93072e80f89", 0, "10e02d0c-0126-4160-ae6f-f25ec6252202", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIsjySaaa9LtoezwL26PcguIR0Oyh79/43o5hoLz64izBOYdDJq9TNj1+rqF8KHx+g==", "0123456789", true, "22f5c299-9448-40bc-808e-cf2277c8d25e", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 47, 34, 46, DateTimeKind.Local).AddTicks(3351), "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 47, 34, 46, DateTimeKind.Local).AddTicks(3671), "35d44107-5eee-47d4-b117-e93072e80f89" });

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "decore1.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "decore2.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "decore3.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "decore4.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "decore5.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "decore6.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "decore7.jpg");

            migrationBuilder.UpdateData(
                table: "DecoreImage",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "decore8.jpg");

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
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "7.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "8.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "9.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "10.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "11.jpg");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "12.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "makeup1.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "makeup2.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "makeup3.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "makeup4.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "makeup5.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "makeup6.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "makeup7.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "makeup8.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "makeup9.jpg");

            migrationBuilder.UpdateData(
                table: "MakeUpImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "makeup10.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "session1_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "session2_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "session3_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "session4_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "session5_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "session6_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "session7_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "session8_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "session9_1.jpg");

            migrationBuilder.UpdateData(
                table: "SessionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "session10_1.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "1.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "2.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "3.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "4.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "5.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "6.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "7.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "8.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "9.jpg");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "10.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "35d44107-5eee-47d4-b117-e93072e80f89" });
        }
    }
}
