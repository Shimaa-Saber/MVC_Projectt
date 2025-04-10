﻿// <auto-generated />
using System;
using MVC_Projec2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Projec2.Migrations
{
    [DbContext(typeof(MVCProjectContext))]
    partial class MVCProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Projec2.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e12d3492-81e2-4aa5-950f-5d157c1cbbbd",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELP4DRd/2FbTIHuPLLnjrriLPxv1Yl9yzKiA7sFEBoI+x/wNvg0aI2flefuQIn7FJw==",
                            PhoneNumber = "0123456789",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "5e65a52c-c1d4-42b8-8107-b3bca99ee3a5",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "1f51c268-9039-4109-a816-6fd3b884d3fe",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cd1943e0-a09d-4d50-9d76-136b267b9226",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "user@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@EXAMPLE.COM",
                            NormalizedUserName = "USER@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBH7apUbYTO2pZBXDRyf/QWlFL1uJjoFPBr+SHTUn7YHiIQzm4Qs92ou0/gKJBuV5A==",
                            PhoneNumber = "9876543210",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "737108ad-29a6-4f97-88bc-61d902202701",
                            TwoFactorEnabled = false,
                            UserName = "user@example.com"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Atelier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("priceRange")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Ateliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = false,
                            Location = "Downtown",
                            Name = "Elite Atelier"
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = false,
                            Location = "Uptown",
                            Name = "Royal Designs"
                        },
                        new
                        {
                            Id = 3,
                            IsAvailable = false,
                            Location = "City Center",
                            Name = "Glamorous Styles"
                        },
                        new
                        {
                            Id = 4,
                            IsAvailable = false,
                            Location = "Suburb",
                            Name = "Elegant Creations"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Atelier_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Decor_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Hall_Id")
                        .HasColumnType("int");

                    b.Property<int?>("MakeupId")
                        .HasColumnType("int");

                    b.Property<int?>("Session_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Atelier_Id");

                    b.HasIndex("Decor_Id");

                    b.HasIndex("Hall_Id");

                    b.HasIndex("MakeupId");

                    b.HasIndex("Session_Id");

                    b.HasIndex("user_id");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atelier_Id = 3,
                            Created_at = new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(458),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            Status = "Confirmed",
                            user_id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145"
                        },
                        new
                        {
                            Id = 2,
                            Atelier_Id = 1,
                            Created_at = new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Decor_Id = 2,
                            Hall_Id = 1,
                            MakeupId = 4,
                            Session_Id = 1,
                            Status = "Pending",
                            user_id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145"
                        },
                        new
                        {
                            Id = 3,
                            Atelier_Id = 3,
                            Created_at = new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(659),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            Status = "Confirmed",
                            user_id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145"
                        },
                        new
                        {
                            Id = 4,
                            Atelier_Id = 1,
                            Created_at = new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Decor_Id = 2,
                            Hall_Id = 1,
                            MakeupId = 4,
                            Session_Id = 1,
                            Status = "Pending",
                            user_id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Atelier_Id")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Decor_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Hall_Id")
                        .HasColumnType("int");

                    b.Property<int?>("MakeupId")
                        .HasColumnType("int");

                    b.Property<int?>("Session_Id")
                        .HasColumnType("int");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Atelier_Id");

                    b.HasIndex("Decor_Id");

                    b.HasIndex("Hall_Id");

                    b.HasIndex("MakeupId");

                    b.HasIndex("Session_Id");

                    b.HasIndex("user_id");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atelier_Id = 3,
                            Content = "Excellent service!",
                            Created_at = new DateTime(2025, 4, 10, 14, 5, 6, 738, DateTimeKind.Local).AddTicks(805),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            user_id = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Decor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Decors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 5000,
                            Style = "Classic"
                        },
                        new
                        {
                            Id = 2,
                            Price = 7000,
                            Style = "Modern"
                        },
                        new
                        {
                            Id = 3,
                            Price = 4500,
                            Style = "Rustic"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.DecoreImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DecorId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DecorId");

                    b.ToTable("DecoreImages");
                });

            modelBuilder.Entity("MVC_Projec2.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 500,
                            ImageUrl = "1.jpg",
                            Name = "Grand Hall"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 300,
                            ImageUrl = "3.jpg",
                            Name = "Crystal Ballroom"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 200,
                            ImageUrl = "5.jpg",
                            Name = "Sunset Venue"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.HallImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("HallImages");
                });

            modelBuilder.Entity("MVC_Projec2.Models.MakeUp_Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MakeUpServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bridal Makeup",
                            Price = 1500
                        },
                        new
                        {
                            Id = 2,
                            Name = "Party Glam",
                            Price = 800
                        },
                        new
                        {
                            Id = 3,
                            Name = "Natural Look",
                            Price = 500
                        },
                        new
                        {
                            Id = 4,
                            Name = "Evening Elegance",
                            Price = 1000
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 2,
                            ImageUrl = "1.jpg",
                            Type = "Photography"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 3,
                            ImageUrl = "2.jpg",
                            Type = "Videography"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 4,
                            ImageUrl = "3.jpg",
                            Type = "Engagement Shoot"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 5,
                            ImageUrl = "4.jpg",
                            Type = "Pre-Wedding Shoot"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "2f45d3b1-6fab-45f9-9b36-c0ba9c736145",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "1f51c268-9039-4109-a816-6fd3b884d3fe",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVC_Projec2.Models.Booking", b =>
                {
                    b.HasOne("MVC_Projec2.Models.Atelier", "Atelier")
                        .WithMany()
                        .HasForeignKey("Atelier_Id");

                    b.HasOne("MVC_Projec2.Models.Decor", "Decor")
                        .WithMany()
                        .HasForeignKey("Decor_Id");

                    b.HasOne("MVC_Projec2.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("Hall_Id");

                    b.HasOne("MVC_Projec2.Models.MakeUp_Service", "MakeUp")
                        .WithMany()
                        .HasForeignKey("MakeupId");

                    b.HasOne("MVC_Projec2.Models.Session", "Session")
                        .WithMany()
                        .HasForeignKey("Session_Id");

                    b.HasOne("MVC_Projec2.Models.ApplicationUser", "user")
                        .WithMany("Bookings")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atelier");

                    b.Navigation("Decor");

                    b.Navigation("Hall");

                    b.Navigation("MakeUp");

                    b.Navigation("Session");

                    b.Navigation("user");
                });

            modelBuilder.Entity("MVC_Projec2.Models.Comment", b =>
                {
                    b.HasOne("MVC_Projec2.Models.Atelier", "Atelier")
                        .WithMany()
                        .HasForeignKey("Atelier_Id");

                    b.HasOne("MVC_Projec2.Models.Decor", "Decor")
                        .WithMany()
                        .HasForeignKey("Decor_Id");

                    b.HasOne("MVC_Projec2.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("Hall_Id");

                    b.HasOne("MVC_Projec2.Models.MakeUp_Service", "MakeUp")
                        .WithMany()
                        .HasForeignKey("MakeupId");

                    b.HasOne("MVC_Projec2.Models.Session", "Session")
                        .WithMany()
                        .HasForeignKey("Session_Id");

                    b.HasOne("MVC_Projec2.Models.ApplicationUser", "user")
                        .WithMany("Comments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atelier");

                    b.Navigation("Decor");

                    b.Navigation("Hall");

                    b.Navigation("MakeUp");

                    b.Navigation("Session");

                    b.Navigation("user");
                });

            modelBuilder.Entity("MVC_Projec2.Models.DecoreImage", b =>
                {
                    b.HasOne("MVC_Projec2.Models.Decor", "Decor")
                        .WithMany("Images")
                        .HasForeignKey("DecorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Decor");
                });

            modelBuilder.Entity("MVC_Projec2.Models.HallImage", b =>
                {
                    b.HasOne("MVC_Projec2.Models.Hall", "Hall")
                        .WithMany("Images")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("MVC_Projec2.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MVC_Projec2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_Projec2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("MVC_Projec2.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Projec2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_Projec2.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Projec2.Models.ApplicationUser", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MVC_Projec2.Models.Decor", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("MVC_Projec2.Models.Hall", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
