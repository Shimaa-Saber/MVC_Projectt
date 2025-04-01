using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ateliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ateliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password_hash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hall_Id = table.Column<int>(type: "int", nullable: true),
                    Session_Id = table.Column<int>(type: "int", nullable: true),
                    Atelier_Id = table.Column<int>(type: "int", nullable: true),
                    MakeupId = table.Column<int>(type: "int", nullable: true),
                    Decor_Id = table.Column<int>(type: "int", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Ateliers_Atelier_Id",
                        column: x => x.Atelier_Id,
                        principalTable: "Ateliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Decors_Decor_Id",
                        column: x => x.Decor_Id,
                        principalTable: "Decors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_MakeUpServices_MakeupId",
                        column: x => x.MakeupId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Sessions_Session_Id",
                        column: x => x.Session_Id,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hall_Id = table.Column<int>(type: "int", nullable: true),
                    Session_Id = table.Column<int>(type: "int", nullable: true),
                    Atelier_Id = table.Column<int>(type: "int", nullable: true),
                    MakeupId = table.Column<int>(type: "int", nullable: true),
                    Decor_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Ateliers_Atelier_Id",
                        column: x => x.Atelier_Id,
                        principalTable: "Ateliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Decors_Decor_Id",
                        column: x => x.Decor_Id,
                        principalTable: "Decors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_MakeUpServices_MakeupId",
                        column: x => x.MakeupId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Sessions_Session_Id",
                        column: x => x.Session_Id,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Downtown", "Elite Atelier" },
                    { 2, "Uptown", "Royal Designs" },
                    { 3, "City Center", "Glamorous Styles" },
                    { 4, "Suburb", "Elegant Creations" }
                });

            migrationBuilder.InsertData(
                table: "Decors",
                columns: new[] { "Id", "Price", "Style" },
                values: new object[,]
                {
                    { 1, 5000, "Classic" },
                    { 2, 7000, "Modern" },
                    { 3, 4500, "Rustic" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, 500, "Grand Hall" },
                    { 2, 300, "Crystal Ballroom" },
                    { 3, 200, "Sunset Venue" }
                });

            migrationBuilder.InsertData(
                table: "MakeUpServices",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Bridal Makeup", 1500 },
                    { 2, "Party Glam", 800 },
                    { 3, "Natural Look", 500 },
                    { 4, "Evening Elegance", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Duration", "Type" },
                values: new object[,]
                {
                    { 1, 2, "Photography" },
                    { 2, 3, "Videography" },
                    { 3, 4, "Engagement Shoot" },
                    { 4, 5, "Pre-Wedding Shoot" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created_at", "Email", "Name", "Password_hash", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4128), "h@gmail.com", "Hager", "h_123@20", "01113986645" },
                    { 2, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "a@gmail.com", "Asmaa", "a@5002", "01213986647" },
                    { 3, new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4183), "s@gmail.com", "Shimaa", "s123@4", "01013986647" },
                    { 4, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "f@gmail.com", "Fatma", "f1@237", "01118936647" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "User_Id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4343), 1, 2, 1, 2, "Confirmed", 1 },
                    { 2, 1, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", 3 },
                    { 3, 4, new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4353), 3, 1, 3, 4, "Cancelled", 2 },
                    { 4, 2, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, 3, 2, 3, "Confirmed", 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Atelier_Id", "Content", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "User_Id" },
                values: new object[,]
                {
                    { 1, 3, "Excellent service!", new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4385), 1, 2, 1, 2, 3 },
                    { 2, 3, "Loved the decorations!", new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4390), 1, 2, 1, 2, 1 },
                    { 3, 3, "Great experience, highly recommend!", new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4393), 1, 2, 1, 2, 4 },
                    { 4, 3, "Nice ambiance but service could be better.", new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4396), 1, 2, 1, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Atelier_Id",
                table: "Bookings",
                column: "Atelier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Decor_Id",
                table: "Bookings",
                column: "Decor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Hall_Id",
                table: "Bookings",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MakeupId",
                table: "Bookings",
                column: "MakeupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Session_Id",
                table: "Bookings",
                column: "Session_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_User_Id",
                table: "Bookings",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Atelier_Id",
                table: "Comments",
                column: "Atelier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Decor_Id",
                table: "Comments",
                column: "Decor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Hall_Id",
                table: "Comments",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MakeupId",
                table: "Comments",
                column: "MakeupId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Session_Id",
                table: "Comments",
                column: "Session_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_Id",
                table: "Comments",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Ateliers");

            migrationBuilder.DropTable(
                name: "Decors");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "MakeUpServices");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
