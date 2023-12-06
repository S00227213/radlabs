using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Week10ClassLibraryS00227213.Migrations
{
    /// <inheritdoc />
    public partial class initialdbsetupandseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FirstName", "RegistrationDate", "SecondName" },
                values: new object[,]
                {
                    { "S00002529", "John", new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodman" },
                    { "S00023092", "Jan", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kotas" },
                    { "S00046565", "John", new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards" },
                    { "S00078018", "Ming-Yang", new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xie" },
                    { "S00113203", "Bryn Paul", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dunton" },
                    { "S00114203", "Martin", new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "O�Donnell" },
                    { "S00132212", "Steven", new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thorpe" },
                    { "S00156910", "Luciana", new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramos" },
                    { "S00170776", "Daniel", new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goldschmidt" },
                    { "S00213687", "Mariya", new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergienko" },
                    { "S00225481", "Cornelia", new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weiler" },
                    { "S00241057", "Bernard", new DateTime(2020, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tham" },
                    { "S00274643", "Antonio", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gratacos Solsona" },
                    { "S00278258", "Anna", new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bedecs" },
                    { "S00287450", "Carlos", new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grilo" },
                    { "S00303021", "Madeleine", new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelley" },
                    { "S00342403", "Nancy", new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freehafer" },
                    { "S00360626", "Thomas", new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Axen" },
                    { "S00360809", "Sven", new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mortensen" },
                    { "S00380454", "Run", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liu" },
                    { "S00387552", "Soo Jung", new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee" },
                    { "S00389325", "Michael", new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Entin" },
                    { "S00413210", "Michael", new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neipper" },
                    { "S00430473", "Anne", new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hellung-Larsen" },
                    { "S00442638", "Andre", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ludick" },
                    { "S00449490", "Naoki", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sato" },
                    { "S00452407", "Francisco", new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "P�rez-Olaeta" },
                    { "S00472973", "Elizabeth", new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andersen" },
                    { "S00483498", "George", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Li" },
                    { "S00540216", "Christina", new DateTime(2020, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee" },
                    { "S00585868", "Elizabeth A.", new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andersen" },
                    { "S00586142", "Amaya", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez-Echevarria" },
                    { "S00599865", "Roland", new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wacker" },
                    { "S00633249", "Stuart", new DateTime(2020, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glasson" },
                    { "S00634533", "Karen", new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toh" },
                    { "S00636735", "Jonas", new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselberg" },
                    { "S00698845", "Alexander", new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eggerer" },
                    { "S00757976", "Helena", new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kupkova" },
                    { "S00806042", "Catherine", new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autier Miconi" },
                    { "S00838203", "Andrew", new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cencini" },
                    { "S00873144", "Jean Philippe", new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bagel" },
                    { "S00880651", "Satomi", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayakawa" },
                    { "S00913453", "Luis", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sousa" },
                    { "S00932913", "Mikael", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandberg" },
                    { "S00947280", "Peter", new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krschne" },
                    { "S00967156", "Robert", new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zare" },
                    { "S00971382", "Amritansh", new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raghav" },
                    { "S00978944", "Laura", new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giussani" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
