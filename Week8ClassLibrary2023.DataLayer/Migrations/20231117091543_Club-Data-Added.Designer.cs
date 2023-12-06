﻿// <auto-generated />
using System;
using ClubModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Week8ClassLibrary2023.DataLayer.Migrations
{
    [DbContext(typeof(ClubsContext))]
    [Migration("20231117091543_Club-Data-Added")]
    partial class ClubDataAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClubModels.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubId"));

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("date");

                    b.Property<int>("adminID")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.ToTable("Club");

                    b.HasData(
                        new
                        {
                            ClubId = 1,
                            ClubName = "Basketball Club",
                            CreationDate = new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(431),
                            adminID = 1
                        },
                        new
                        {
                            ClubId = 2,
                            ClubName = "Football Club",
                            CreationDate = new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(455),
                            adminID = 2
                        },
                        new
                        {
                            ClubId = 3,
                            ClubName = "Boxing Club",
                            CreationDate = new DateTime(2023, 11, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(457),
                            adminID = 3
                        });
                });

            modelBuilder.Entity("ClubModels.ClubEvent", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.HasIndex("ClubId");

                    b.ToTable("ClubEvent");

                    b.HasData(
                        new
                        {
                            EventID = 1,
                            ClubId = 1,
                            EndDateTime = new DateTime(2023, 12, 17, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(625),
                            Location = "Tallaght, Dublin",
                            StartDateTime = new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(621),
                            Venue = "National Basketball Arena"
                        },
                        new
                        {
                            EventID = 2,
                            ClubId = 1,
                            EndDateTime = new DateTime(2024, 1, 1, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(630),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(628),
                            Venue = "Local Sports Center"
                        },
                        new
                        {
                            EventID = 3,
                            ClubId = 1,
                            EndDateTime = new DateTime(2024, 1, 16, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(633),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(632),
                            Venue = "City Arena"
                        },
                        new
                        {
                            EventID = 4,
                            ClubId = 1,
                            EndDateTime = new DateTime(2024, 1, 31, 13, 15, 43, 308, DateTimeKind.Local).AddTicks(637),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(635),
                            Venue = "University Courts"
                        },
                        new
                        {
                            EventID = 5,
                            ClubId = 2,
                            EndDateTime = new DateTime(2023, 12, 17, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(640),
                            Location = "Ballsbridge, Dublin",
                            StartDateTime = new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(639),
                            Venue = "Aviva Stadium"
                        },
                        new
                        {
                            EventID = 6,
                            ClubId = 2,
                            EndDateTime = new DateTime(2024, 1, 1, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(643),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(642),
                            Venue = "Local Football Pitch"
                        },
                        new
                        {
                            EventID = 7,
                            ClubId = 2,
                            EndDateTime = new DateTime(2024, 1, 16, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(647),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(646),
                            Venue = "National Football Field"
                        },
                        new
                        {
                            EventID = 8,
                            ClubId = 2,
                            EndDateTime = new DateTime(2024, 1, 31, 12, 15, 43, 308, DateTimeKind.Local).AddTicks(650),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(649),
                            Venue = "University Stadium"
                        },
                        new
                        {
                            EventID = 9,
                            ClubId = 3,
                            EndDateTime = new DateTime(2023, 12, 17, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(654),
                            Location = "South Circular Road, Dublin",
                            StartDateTime = new DateTime(2023, 12, 17, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(652),
                            Venue = "National Boxing Stadium"
                        },
                        new
                        {
                            EventID = 10,
                            ClubId = 3,
                            EndDateTime = new DateTime(2024, 1, 1, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(657),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 1, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(656),
                            Venue = "Downtown Boxing Gym"
                        },
                        new
                        {
                            EventID = 11,
                            ClubId = 3,
                            EndDateTime = new DateTime(2024, 1, 16, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(660),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 16, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(659),
                            Venue = "Local Gym"
                        },
                        new
                        {
                            EventID = 12,
                            ClubId = 3,
                            EndDateTime = new DateTime(2024, 1, 31, 11, 15, 43, 308, DateTimeKind.Local).AddTicks(664),
                            Location = "Dublin",
                            StartDateTime = new DateTime(2024, 1, 31, 9, 15, 43, 308, DateTimeKind.Local).AddTicks(662),
                            Venue = "Community Center Arena"
                        });
                });

            modelBuilder.Entity("ClubModels.ClubEvent", b =>
                {
                    b.HasOne("ClubModels.Club", "associatedClub")
                        .WithMany("clubEvents")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("associatedClub");
                });

            modelBuilder.Entity("ClubModels.Club", b =>
                {
                    b.Navigation("clubEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
