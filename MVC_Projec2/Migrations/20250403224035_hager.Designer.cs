﻿// <auto-generated />
using System;
using MVC_Projec2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Projec2.Migrations
{
    [DbContext(typeof(MVCProjectContext))]
    [Migration("20250403224035_hager")]
    partial class hager
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            Id = "0749a18c-980f-4fb3-8bd2-9184f1e7d77b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55c67237-fae1-4887-8195-184d91a6eef4",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELXXRUmPgzRcP2R/NTFWmmKf1g7vKeZEugKXN81rtTUPlCXtGDnpQ/27k++tUewdDw==",
                            PhoneNumber = "0123456789",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "21fb369f-a4b0-4a42-9d52-a8ca6106484d",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Atelier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ateliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Downtown",
                            Name = "Elite Atelier"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Uptown",
                            Name = "Royal Designs"
                        },
                        new
                        {
                            Id = 3,
                            Location = "City Center",
                            Name = "Glamorous Styles"
                        },
                        new
                        {
                            Id = 4,
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
                            Created_at = new DateTime(2025, 4, 4, 0, 40, 34, 31, DateTimeKind.Local).AddTicks(7144),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            Status = "Confirmed",
                            user_id = "0749a18c-980f-4fb3-8bd2-9184f1e7d77b"
                        },
                        new
                        {
                            Id = 2,
                            Atelier_Id = 1,
                            Created_at = new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Decor_Id = 2,
                            Hall_Id = 1,
                            MakeupId = 4,
                            Session_Id = 1,
                            Status = "Pending",
                            user_id = "0749a18c-980f-4fb3-8bd2-9184f1e7d77b"
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
                            Created_at = new DateTime(2025, 4, 4, 0, 40, 34, 31, DateTimeKind.Local).AddTicks(7307),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            user_id = "0749a18c-980f-4fb3-8bd2-9184f1e7d77b"
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
                            Name = "Grand Hall"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 300,
                            Name = "Crystal Ballroom"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 200,
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

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 2,
                            Type = "Photography"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 3,
                            Type = "Videography"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 4,
                            Type = "Engagement Shoot"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 5,
                            Type = "Pre-Wedding Shoot"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                            UserId = "0749a18c-980f-4fb3-8bd2-9184f1e7d77b",
                            RoleId = "1"
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
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
