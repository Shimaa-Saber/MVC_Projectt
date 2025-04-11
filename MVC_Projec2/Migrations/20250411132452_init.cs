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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ateliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    priceRange = table.Column<double>(type: "float", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
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
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtelierImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtelierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtelierImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtelierImages_Ateliers_AtelierId",
                        column: x => x.AtelierId,
                        principalTable: "Ateliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecoreImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecoreImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecoreImage_Decors_DecorId",
                        column: x => x.DecorId,
                        principalTable: "Decors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HallImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HallImages_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeUpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakeUpImages_MakeUpServices_MakeUpId",
                        column: x => x.MakeUpId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "SessionImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionImages_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82074630-fe2b-4689-8c51-ab5a48732036", 0, "1ffd82fc-a946-4297-8b29-50d1833d5295", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAENKv1sPw/2QZ9PHQKszrg1L5haAAHBs3YyobTNkt1rZ3yYna3g2vNu8GGL+PcHez2g==", "0123456789", true, "4eb97bb1-e94a-46ca-8ee6-af9d3a3cf9d9", false, "admin@example.com" },
                    { "b20c409c-e1ff-4b34-b7af-477e4a443768", 0, "9f110e21-614e-4c06-a284-bcdb9cabed38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", true, null, false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGsC29wLucp811HTH8EeL02OcaZDgAUKqVc7q07KJG8SMUPq839R2t4i3y2jOOv8zw==", "9876543210", true, "a0c4c242-b81b-4798-aa95-d37c1181a014", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "ImageURL", "Location", "Name", "priceRange" },
                values: new object[,]
                {
                    { 1, null, "Downtown", "Elite Atelier", 5000.0 },
                    { 2, null, "Uptown", "Royal Designs", 3000.0 },
                    { 3, null, "City Center", "Glamorous Styles", 5000.0 },
                    { 4, null, "Suburb", "Elegant Creations", 3000.0 },
                    { 5, null, "North Park", "Chic Styles", 1500.0 },
                    { 6, null, "South Side", "Vintage Touch", 2500.0 },
                    { 7, null, "Midtown", "Modern Artistry", 5000.0 },
                    { 8, null, "East End", "Exquisite Design", 2500.0 },
                    { 9, null, "West End", "Timeless Beauty", 5000.0 },
                    { 10, null, "Central Square", "Fashion Forward", 1500.0 }
                });

            migrationBuilder.InsertData(
                table: "Decors",
                columns: new[] { "Id", "Description", "Price", "Style" },
                values: new object[,]
                {
                    { 1, "Timeless decor with elegant and traditional designs, perfect for a sophisticated atmosphere.", 5000, "Classic" },
                    { 2, "Sleek and contemporary design with clean lines and minimalistic features.", 7000, "Modern" },
                    { 3, "Natural and earthy designs featuring wood, stone, and vintage elements for a cozy feel.", 4500, "Rustic" },
                    { 4, "Retro-inspired decor with nostalgic and old-world charm, ideal for classic settings.", 5500, "Vintage" },
                    { 5, "Rough and raw designs with exposed metals, bricks, and unfinished elements.", 6000, "Industrial" },
                    { 6, "Bohemian style with vibrant colors, eclectic patterns, and artistic, free-spirited elements.", 4000, "Boho" },
                    { 7, "Simplicity at its finest, focusing on clean spaces and functional, uncluttered designs.", 6500, "Minimalist" },
                    { 8, "Luxurious and glamorous style featuring bold geometric patterns and rich colors.", 7000, "Art Deco" },
                    { 9, "High-end and dazzling decor with rich textures, metallic accents, and sophisticated lighting.", 8000, "Glam" },
                    { 10, "A charming, weathered look with soft pastel colors, distressed furniture, and vintage accessories.", 4500, "Shabby Chic" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 500, "Cairo", "Grand Hall", 10000.0 },
                    { 2, 300, "Alexandria", "Crystal Ballroom", 8000.0 },
                    { 3, 200, "Sharm El Sheikh", "Sunset Venue", 5000.0 },
                    { 4, 400, "Giza", "Majestic Hall", 9000.0 },
                    { 5, 350, "Hurghada", "Ocean View", 7500.0 },
                    { 6, 600, "New Cairo", "Skyline Pavilion", 12000.0 },
                    { 7, 250, "Tanta", "Moonlight Hall", 6000.0 },
                    { 8, 450, "Mansoura", "Royal Suite", 11000.0 },
                    { 9, 500, "Port Said", "Elite Venue", 10500.0 },
                    { 10, 700, "Luxor", "Luxury Retreat", 15000.0 }
                });

            migrationBuilder.InsertData(
                table: "MakeUpServices",
                columns: new[] { "Id", "Desc", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Flawless makeup designed to enhance the bride's natural beauty for her special day.", null, "Bridal Makeup", 1500 },
                    { 2, "Bold and glamorous makeup for parties and social events.", null, "Party Glam", 800 },
                    { 3, "A subtle and fresh makeup style for everyday wear.", null, "Natural Look", 500 },
                    { 4, "Sophisticated makeup perfect for evening events and dinners.", null, "Evening Elegance", 1000 },
                    { 5, "Shimmery and radiant makeup for a glamorous, standout look.", null, "Glamour Shine", 1200 },
                    { 6, "Vibrant and creative makeup for festivals and fun events.", null, "Festival Glam", 700 },
                    { 7, "Radiant and glowing makeup designed for brides who want a luminous look.", null, "Bridal Glow", 1600 },
                    { 8, "Elegant makeup for special events like anniversaries and galas.", null, "Special Occasion", 1300 },
                    { 9, "High-fashion makeup inspired by the looks of celebrities and runway models.", null, "Celebrity Look", 2000 },
                    { 10, "Refined and minimalist makeup for a naturally elegant look.", null, "Simple Elegance", 600 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Duration", "ImageUrl", "Location", "Name", "Price", "Type", "desc" },
                values: new object[,]
                {
                    { 1, 2, null, "Cairo", "Basic Photography Package", 3000.0, "Photography", null },
                    { 2, 3, null, "Alexandria", "Videography Session", 4000.0, "Videography", null },
                    { 3, 4, null, "Giza", "Engagement Photography", 3500.0, "Engagement Shoot", null },
                    { 4, 5, null, "Sharm El Sheikh", "Pre-Wedding Photoshoot", 4500.0, "Pre-Wedding Shoot", null },
                    { 5, 6, null, "Luxor", "Wedding Day Coverage", 8000.0, "Wedding Photography", null },
                    { 6, 2, null, "New Cairo", "Couple Photography", 2500.0, "Couple Shoot", null },
                    { 7, 3, null, "Tanta", "Bridal Portrait Session", 3000.0, "Bridal Portraits", null },
                    { 8, 4, null, "Mansoura", "Fashion Photo Session", 5000.0, "Fashion Photography", null },
                    { 9, 5, null, "Hurghada", "Event Videography & Photography", 6000.0, "Event Coverage", null },
                    { 10, 3, null, "Port Said", "Family Photography", 3500.0, "Family Shoot", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "82074630-fe2b-4689-8c51-ab5a48732036" },
                    { "2", "b20c409c-e1ff-4b34-b7af-477e4a443768" }
                });

            migrationBuilder.InsertData(
                table: "AtelierImages",
                columns: new[] { "Id", "AtelierId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "atelier1.jpg" },
                    { 2, 2, "atelier2.jpg" },
                    { 3, 3, "atelier3.jpg" },
                    { 4, 4, "atelier4.jpg" },
                    { 5, 5, "atelier5.jpg" },
                    { 6, 6, "atelier6.jpg" },
                    { 7, 7, "atelier7.jpg" },
                    { 8, 8, "atelier8.jpg" },
                    { 9, 9, "atelier9.jpg" },
                    { 10, 10, "atelier10.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(3456), 1, 2, 1, 2, "Confirmed", "82074630-fe2b-4689-8c51-ab5a48732036" },
                    { 2, 1, new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "82074630-fe2b-4689-8c51-ab5a48732036" },
                    { 3, 3, new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(3780), 1, 2, 1, 2, "Confirmed", "82074630-fe2b-4689-8c51-ab5a48732036" },
                    { 4, 1, new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "82074630-fe2b-4689-8c51-ab5a48732036" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ServiceId", "ServiceType", "UserId" },
                values: new object[] { 1, "Excellent service!", new DateTime(2025, 4, 11, 15, 24, 50, 604, DateTimeKind.Local).AddTicks(4282), 0, 0, "82074630-fe2b-4689-8c51-ab5a48732036" });

            migrationBuilder.InsertData(
                table: "DecoreImage",
                columns: new[] { "Id", "DecorId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "decor1.jpg" },
                    { 2, 2, "decor2.jpg" },
                    { 3, 3, "decor3.jpg" },
                    { 4, 4, "decor4.jpg" },
                    { 5, 5, "decor5.jpg" },
                    { 6, 6, "decor6.jpg" },
                    { 7, 7, "decor7.jpg" },
                    { 8, 8, "decor8.jpg" }
                });

            migrationBuilder.InsertData(
                table: "HallImages",
                columns: new[] { "Id", "HallId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "hall1.jpg" },
                    { 2, 2, "hall2.jpg" },
                    { 3, 3, "hall3.jpg" },
                    { 4, 4, "hall4.jpg" },
                    { 5, 5, "hall5.jpg" },
                    { 6, 6, "hall6.jpg" },
                    { 7, 7, "hall7.jpg" },
                    { 8, 8, "hall8.jpg" },
                    { 9, 9, "hall9.jpg" },
                    { 10, 10, "hall10.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MakeUpImages",
                columns: new[] { "Id", "ImageUrl", "MakeUpId" },
                values: new object[,]
                {
                    { 1, "makeUp1.jpg", 1 },
                    { 2, "makeUp2.jpg", 2 },
                    { 3, "makeUp3.jpg", 3 },
                    { 4, "makeUp4.jpg", 4 },
                    { 5, "makeUp5.jpg", 5 },
                    { 6, "makeUp6.jpg", 6 },
                    { 7, "makeUp7.jpg", 7 },
                    { 8, "makeUp8.jpg", 8 },
                    { 9, "makeUp9.jpg", 9 },
                    { 10, "makeUp10.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "SessionImages",
                columns: new[] { "Id", "ImageUrl", "SessionId" },
                values: new object[,]
                {
                    { 1, "session1.jpg", 1 },
                    { 2, "session2.jpg", 2 },
                    { 3, "session3.jpg", 3 },
                    { 4, "session4.jpg", 4 },
                    { 5, "session5.jpg", 5 },
                    { 6, "session6.jpg", 6 },
                    { 7, "session7.jpg", 7 },
                    { 8, "session8.jpg", 8 },
                    { 9, "session9.jpg", 9 },
                    { 10, "session10.jpg", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AtelierImages_AtelierId",
                table: "AtelierImages",
                column: "AtelierId");

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
                name: "IX_Bookings_user_id",
                table: "Bookings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DecoreImage_DecorId",
                table: "DecoreImage",
                column: "DecorId");

            migrationBuilder.CreateIndex(
                name: "IX_HallImages_HallId",
                table: "HallImages",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_MakeUpImages_MakeUpId",
                table: "MakeUpImages",
                column: "MakeUpId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionImages_SessionId",
                table: "SessionImages",
                column: "SessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AtelierImages");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DecoreImage");

            migrationBuilder.DropTable(
                name: "HallImages");

            migrationBuilder.DropTable(
                name: "MakeUpImages");

            migrationBuilder.DropTable(
                name: "SessionImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ateliers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Decors");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "MakeUpServices");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
