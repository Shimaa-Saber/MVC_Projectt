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

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Atelier_Id");

                    b.HasIndex("Decor_Id");

                    b.HasIndex("Hall_Id");

                    b.HasIndex("MakeupId");

                    b.HasIndex("Session_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atelier_Id = 3,
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4343),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            Status = "Confirmed",
                            User_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            Atelier_Id = 1,
                            Created_at = new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Decor_Id = 2,
                            Hall_Id = 1,
                            MakeupId = 4,
                            Session_Id = 1,
                            Status = "Pending",
                            User_Id = 3
                        },
                        new
                        {
                            Id = 3,
                            Atelier_Id = 4,
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4353),
                            Decor_Id = 3,
                            Hall_Id = 1,
                            MakeupId = 3,
                            Session_Id = 4,
                            Status = "Cancelled",
                            User_Id = 2
                        },
                        new
                        {
                            Id = 4,
                            Atelier_Id = 2,
                            Created_at = new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Decor_Id = 1,
                            Hall_Id = 3,
                            MakeupId = 2,
                            Session_Id = 3,
                            Status = "Confirmed",
                            User_Id = 4
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

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Atelier_Id");

                    b.HasIndex("Decor_Id");

                    b.HasIndex("Hall_Id");

                    b.HasIndex("MakeupId");

                    b.HasIndex("Session_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atelier_Id = 3,
                            Content = "Excellent service!",
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4385),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            User_Id = 3
                        },
                        new
                        {
                            Id = 2,
                            Atelier_Id = 3,
                            Content = "Loved the decorations!",
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4390),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            User_Id = 1
                        },
                        new
                        {
                            Id = 3,
                            Atelier_Id = 3,
                            Content = "Great experience, highly recommend!",
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4393),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            User_Id = 4
                        },
                        new
                        {
                            Id = 4,
                            Atelier_Id = 3,
                            Content = "Nice ambiance but service could be better.",
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4396),
                            Decor_Id = 1,
                            Hall_Id = 2,
                            MakeupId = 1,
                            Session_Id = 2,
                            User_Id = 2
                        });
                });

            modelBuilder.Entity("MVC_Projec2.Models.Decor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("MVC_Projec2.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("MVC_Projec2.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password_hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4128),
                            Email = "h@gmail.com",
                            Name = "Hager",
                            Password_hash = "h_123@20",
                            Phone = "01113986645"
                        },
                        new
                        {
                            Id = 2,
                            Created_at = new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "a@gmail.com",
                            Name = "Asmaa",
                            Password_hash = "a@5002",
                            Phone = "01213986647"
                        },
                        new
                        {
                            Id = 3,
                            Created_at = new DateTime(2025, 4, 2, 1, 53, 24, 900, DateTimeKind.Local).AddTicks(4183),
                            Email = "s@gmail.com",
                            Name = "Shimaa",
                            Password_hash = "s123@4",
                            Phone = "01013986647"
                        },
                        new
                        {
                            Id = 4,
                            Created_at = new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "f@gmail.com",
                            Name = "Fatma",
                            Password_hash = "f1@237",
                            Phone = "01118936647"
                        });
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

                    b.HasOne("MVC_Projec2.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atelier");

                    b.Navigation("Decor");

                    b.Navigation("Hall");

                    b.Navigation("MakeUp");

                    b.Navigation("Session");

                    b.Navigation("User");
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

                    b.HasOne("MVC_Projec2.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atelier");

                    b.Navigation("Decor");

                    b.Navigation("Hall");

                    b.Navigation("MakeUp");

                    b.Navigation("Session");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
