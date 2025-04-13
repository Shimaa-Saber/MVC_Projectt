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
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_user_id",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "69518546-5dd8-47ec-bd8d-dae8e17e273a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "ec1493e0-aa69-40cd-a49b-5653d962109b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69518546-5dd8-47ec-bd8d-dae8e17e273a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec1493e0-aa69-40cd-a49b-5653d962109b");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ac34acc1-5db3-43a1-b599-3ae1d9c27bb6", 0, "42943a01-403e-4825-8b36-5d303d0a8886", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIWFDfER0xei2hGHsWXUshF482cZEwygDZ0JCiFxckb91fKWvE6bSvMhvWuegSruIg==", "9876543210", true, "e87f4a61-8d74-4aba-b566-e6d3c464afb7", false, "user@example.com" },
                    { "bba82c32-8ae8-4ee8-a016-24e1b54613e0", 0, "9471ecab-799e-465c-9b6e-316514aea4c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELAi2GIMGRf9HC/ft4ECyqgYJ6LmKhCAZYArWOO/gDoJ3wQBjWktHRX5qoaFFnAwhg==", "0123456789", true, "2572419e-5561-4ce9-a454-384d85458e82", false, "admin@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 13, 3, 33, 11, 253, DateTimeKind.Local).AddTicks(8852), "bba82c32-8ae8-4ee8-a016-24e1b54613e0" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "bba82c32-8ae8-4ee8-a016-24e1b54613e0");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 13, 3, 33, 11, 253, DateTimeKind.Local).AddTicks(9315), "bba82c32-8ae8-4ee8-a016-24e1b54613e0" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "bba82c32-8ae8-4ee8-a016-24e1b54613e0");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 13, 3, 33, 11, 254, DateTimeKind.Local).AddTicks(809), "bba82c32-8ae8-4ee8-a016-24e1b54613e0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "ac34acc1-5db3-43a1-b599-3ae1d9c27bb6" },
                    { "1", "bba82c32-8ae8-4ee8-a016-24e1b54613e0" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_user_id",
                table: "Bookings",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_user_id",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "ac34acc1-5db3-43a1-b599-3ae1d9c27bb6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "bba82c32-8ae8-4ee8-a016-24e1b54613e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac34acc1-5db3-43a1-b599-3ae1d9c27bb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bba82c32-8ae8-4ee8-a016-24e1b54613e0");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69518546-5dd8-47ec-bd8d-dae8e17e273a", 0, "7c7c536a-2b71-47bb-9c1f-ab40681839b2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMPm3zO2FCJEiBEPpq28zltMjIz6z4u2CBdfj0bR1rmOnkVN1hW9zbUJAbpuVTImBA==", "0123456789", true, "5959bbcc-12ef-4f0a-8bf6-b977974dc769", false, "admin@example.com" },
                    { "ec1493e0-aa69-40cd-a49b-5653d962109b", 0, "f4b5c2f9-c7ae-4273-a7f6-3df705293f98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEPiLf50g2NEEG5PG1g8JXM6amyltAbvNMlxMPhaCqZ/kkZZZtxiLOovtqhNyTUVAA==", "9876543210", true, "c400ac79-7a82-4d8d-83b5-8e96c8936570", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 13, 2, 10, 28, 270, DateTimeKind.Local).AddTicks(9627), "69518546-5dd8-47ec-bd8d-dae8e17e273a" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "69518546-5dd8-47ec-bd8d-dae8e17e273a");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 13, 2, 10, 28, 271, DateTimeKind.Local).AddTicks(91), "69518546-5dd8-47ec-bd8d-dae8e17e273a" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "user_id",
                value: "69518546-5dd8-47ec-bd8d-dae8e17e273a");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 13, 2, 10, 28, 271, DateTimeKind.Local).AddTicks(206), "69518546-5dd8-47ec-bd8d-dae8e17e273a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "69518546-5dd8-47ec-bd8d-dae8e17e273a" },
                    { "2", "ec1493e0-aa69-40cd-a49b-5653d962109b" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_user_id",
                table: "Bookings",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
