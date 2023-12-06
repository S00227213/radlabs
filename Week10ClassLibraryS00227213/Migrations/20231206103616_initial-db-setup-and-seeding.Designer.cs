﻿// <auto-generated />
using System;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Week10ClassLibraryS00227213.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20231206103616_initial-db-setup-and-seeding")]
    partial class initialdbsetupandseeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataModel.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("date");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = "S00472973",
                            FirstName = "Elizabeth",
                            RegistrationDate = new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Andersen"
                        },
                        new
                        {
                            StudentID = "S00806042",
                            FirstName = "Catherine",
                            RegistrationDate = new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Autier Miconi"
                        },
                        new
                        {
                            StudentID = "S00360626",
                            FirstName = "Thomas",
                            RegistrationDate = new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Axen"
                        },
                        new
                        {
                            StudentID = "S00873144",
                            FirstName = "Jean Philippe",
                            RegistrationDate = new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Bagel"
                        },
                        new
                        {
                            StudentID = "S00278258",
                            FirstName = "Anna",
                            RegistrationDate = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Bedecs"
                        },
                        new
                        {
                            StudentID = "S00046565",
                            FirstName = "John",
                            RegistrationDate = new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Edwards"
                        },
                        new
                        {
                            StudentID = "S00698845",
                            FirstName = "Alexander",
                            RegistrationDate = new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Eggerer"
                        },
                        new
                        {
                            StudentID = "S00389325",
                            FirstName = "Michael",
                            RegistrationDate = new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Entin"
                        },
                        new
                        {
                            StudentID = "S00170776",
                            FirstName = "Daniel",
                            RegistrationDate = new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Goldschmidt"
                        },
                        new
                        {
                            StudentID = "S00274643",
                            FirstName = "Antonio",
                            RegistrationDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Gratacos Solsona"
                        },
                        new
                        {
                            StudentID = "S00287450",
                            FirstName = "Carlos",
                            RegistrationDate = new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Grilo"
                        },
                        new
                        {
                            StudentID = "S00636735",
                            FirstName = "Jonas",
                            RegistrationDate = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Hasselberg"
                        },
                        new
                        {
                            StudentID = "S00947280",
                            FirstName = "Peter",
                            RegistrationDate = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Krschne"
                        },
                        new
                        {
                            StudentID = "S00757976",
                            FirstName = "Helena",
                            RegistrationDate = new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Kupkova"
                        },
                        new
                        {
                            StudentID = "S00540216",
                            FirstName = "Christina",
                            RegistrationDate = new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Lee"
                        },
                        new
                        {
                            StudentID = "S00387552",
                            FirstName = "Soo Jung",
                            RegistrationDate = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Lee"
                        },
                        new
                        {
                            StudentID = "S00483498",
                            FirstName = "George",
                            RegistrationDate = new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Li"
                        },
                        new
                        {
                            StudentID = "S00380454",
                            FirstName = "Run",
                            RegistrationDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Liu"
                        },
                        new
                        {
                            StudentID = "S00442638",
                            FirstName = "Andre",
                            RegistrationDate = new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Ludick"
                        },
                        new
                        {
                            StudentID = "S00360809",
                            FirstName = "Sven",
                            RegistrationDate = new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Mortensen"
                        },
                        new
                        {
                            StudentID = "S00114203",
                            FirstName = "Martin",
                            RegistrationDate = new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "O�Donnell"
                        },
                        new
                        {
                            StudentID = "S00452407",
                            FirstName = "Francisco",
                            RegistrationDate = new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "P�rez-Olaeta"
                        },
                        new
                        {
                            StudentID = "S00971382",
                            FirstName = "Amritansh",
                            RegistrationDate = new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Raghav"
                        },
                        new
                        {
                            StudentID = "S00156910",
                            FirstName = "Luciana",
                            RegistrationDate = new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Ramos"
                        },
                        new
                        {
                            StudentID = "S00002529",
                            FirstName = "John",
                            RegistrationDate = new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Rodman"
                        },
                        new
                        {
                            StudentID = "S00241057",
                            FirstName = "Bernard",
                            RegistrationDate = new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Tham"
                        },
                        new
                        {
                            StudentID = "S00634533",
                            FirstName = "Karen",
                            RegistrationDate = new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Toh"
                        },
                        new
                        {
                            StudentID = "S00599865",
                            FirstName = "Roland",
                            RegistrationDate = new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Wacker"
                        },
                        new
                        {
                            StudentID = "S00078018",
                            FirstName = "Ming-Yang",
                            RegistrationDate = new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Xie"
                        },
                        new
                        {
                            StudentID = "S00585868",
                            FirstName = "Elizabeth A.",
                            RegistrationDate = new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Andersen"
                        },
                        new
                        {
                            StudentID = "S00113203",
                            FirstName = "Bryn Paul",
                            RegistrationDate = new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Dunton"
                        },
                        new
                        {
                            StudentID = "S00633249",
                            FirstName = "Stuart",
                            RegistrationDate = new DateTime(2020, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Glasson"
                        },
                        new
                        {
                            StudentID = "S00880651",
                            FirstName = "Satomi",
                            RegistrationDate = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Hayakawa"
                        },
                        new
                        {
                            StudentID = "S00586142",
                            FirstName = "Amaya",
                            RegistrationDate = new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Hernandez-Echevarria"
                        },
                        new
                        {
                            StudentID = "S00303021",
                            FirstName = "Madeleine",
                            RegistrationDate = new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Kelley"
                        },
                        new
                        {
                            StudentID = "S00932913",
                            FirstName = "Mikael",
                            RegistrationDate = new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Sandberg"
                        },
                        new
                        {
                            StudentID = "S00449490",
                            FirstName = "Naoki",
                            RegistrationDate = new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Sato"
                        },
                        new
                        {
                            StudentID = "S00913453",
                            FirstName = "Luis",
                            RegistrationDate = new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Sousa"
                        },
                        new
                        {
                            StudentID = "S00225481",
                            FirstName = "Cornelia",
                            RegistrationDate = new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Weiler"
                        },
                        new
                        {
                            StudentID = "S00838203",
                            FirstName = "Andrew",
                            RegistrationDate = new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Cencini"
                        },
                        new
                        {
                            StudentID = "S00342403",
                            FirstName = "Nancy",
                            RegistrationDate = new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Freehafer"
                        },
                        new
                        {
                            StudentID = "S00978944",
                            FirstName = "Laura",
                            RegistrationDate = new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Giussani"
                        },
                        new
                        {
                            StudentID = "S00430473",
                            FirstName = "Anne",
                            RegistrationDate = new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Hellung-Larsen"
                        },
                        new
                        {
                            StudentID = "S00023092",
                            FirstName = "Jan",
                            RegistrationDate = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Kotas"
                        },
                        new
                        {
                            StudentID = "S00413210",
                            FirstName = "Michael",
                            RegistrationDate = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Neipper"
                        },
                        new
                        {
                            StudentID = "S00213687",
                            FirstName = "Mariya",
                            RegistrationDate = new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Sergienko"
                        },
                        new
                        {
                            StudentID = "S00132212",
                            FirstName = "Steven",
                            RegistrationDate = new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Thorpe"
                        },
                        new
                        {
                            StudentID = "S00967156",
                            FirstName = "Robert",
                            RegistrationDate = new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecondName = "Zare"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
