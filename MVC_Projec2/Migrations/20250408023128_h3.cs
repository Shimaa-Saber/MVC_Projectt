using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class h3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_user_id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Ateliers_Atelier_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Decors_Decor_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Halls_Hall_Id",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MakeUpServices_MakeupId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sessions_Session_Id",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0749a18c-980f-4fb3-8bd2-9184f1e7d77b");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Comments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Session_Id",
                table: "Comments",
                newName: "SessionId");

            migrationBuilder.RenameColumn(
                name: "MakeupId",
                table: "Comments",
                newName: "MakeUpServiceId");

            migrationBuilder.RenameColumn(
                name: "Hall_Id",
                table: "Comments",
                newName: "HallId");

            migrationBuilder.RenameColumn(
                name: "Decor_Id",
                table: "Comments",
                newName: "DecorId");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Comments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Atelier_Id",
                table: "Comments",
                newName: "AtelierId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_user_id",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Session_Id",
                table: "Comments",
                newName: "IX_Comments_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_MakeupId",
                table: "Comments",
                newName: "IX_Comments_MakeUpServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Hall_Id",
                table: "Comments",
                newName: "IX_Comments_HallId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Decor_Id",
                table: "Comments",
                newName: "IX_Comments_DecorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Atelier_Id",
                table: "Comments",
                newName: "IX_Comments_AtelierId");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MakeUpServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46", 0, "084eba3e-49f6-4bc0-97fb-2013437699ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPUWAGOHi/TN55c9PR7Ux5iej5fIgX1iPMSGy1Te0M+st1hR0yPxXYrQ9QEt98sSCw==", "0123456789", true, "ebfb4d2c-bdbf-4019-9e7d-b649f456e23f", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Session_Id", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(5866), 1, "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(6173), "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

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
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "MakeUpServices",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2025, 4, 8, 4, 31, 25, 386, DateTimeKind.Local).AddTicks(6052), 1, 2, 1, 2, "Confirmed", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" },
                    { 4, 1, new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Ateliers_AtelierId",
                table: "Comments",
                column: "AtelierId",
                principalTable: "Ateliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Decors_DecorId",
                table: "Comments",
                column: "DecorId",
                principalTable: "Decors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Halls_HallId",
                table: "Comments",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MakeUpServices_MakeUpServiceId",
                table: "Comments",
                column: "MakeUpServiceId",
                principalTable: "MakeUpServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sessions_SessionId",
                table: "Comments",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Ateliers_AtelierId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Decors_DecorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Halls_HallId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_MakeUpServices_MakeUpServiceId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sessions_SessionId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46" });

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
                keyValue: "d34ae9f4-6bb5-41e1-8814-0eba62c5bd46");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MakeUpServices");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "Comments",
                newName: "Session_Id");

            migrationBuilder.RenameColumn(
                name: "MakeUpServiceId",
                table: "Comments",
                newName: "MakeupId");

            migrationBuilder.RenameColumn(
                name: "HallId",
                table: "Comments",
                newName: "Hall_Id");

            migrationBuilder.RenameColumn(
                name: "DecorId",
                table: "Comments",
                newName: "Decor_Id");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Comments",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "AtelierId",
                table: "Comments",
                newName: "Atelier_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                newName: "IX_Comments_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_SessionId",
                table: "Comments",
                newName: "IX_Comments_Session_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_MakeUpServiceId",
                table: "Comments",
                newName: "IX_Comments_MakeupId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_HallId",
                table: "Comments",
                newName: "IX_Comments_Hall_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DecorId",
                table: "Comments",
                newName: "IX_Comments_Decor_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AtelierId",
                table: "Comments",
                newName: "IX_Comments_Atelier_Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0749a18c-980f-4fb3-8bd2-9184f1e7d77b", 0, "55c67237-fae1-4887-8195-184d91a6eef4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELXXRUmPgzRcP2R/NTFWmmKf1g7vKeZEugKXN81rtTUPlCXtGDnpQ/27k++tUewdDw==", "0123456789", true, "21fb369f-a4b0-4a42-9d52-a8ca6106484d", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Session_Id", "user_id" },
                values: new object[] { new DateTime(2025, 4, 3, 22, 40, 9, 259, DateTimeKind.Local).AddTicks(2737), 2, "0749a18c-980f-4fb3-8bd2-9184f1e7d77b" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_user_id",
                table: "Comments",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Ateliers_Atelier_Id",
                table: "Comments",
                column: "Atelier_Id",
                principalTable: "Ateliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Decors_Decor_Id",
                table: "Comments",
                column: "Decor_Id",
                principalTable: "Decors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Halls_Hall_Id",
                table: "Comments",
                column: "Hall_Id",
                principalTable: "Halls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_MakeUpServices_MakeupId",
                table: "Comments",
                column: "MakeupId",
                principalTable: "MakeUpServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sessions_Session_Id",
                table: "Comments",
                column: "Session_Id",
                principalTable: "Sessions",
                principalColumn: "Id");
        }
    }
}
