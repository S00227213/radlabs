using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.WebAPIClient;

namespace DataModel
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext() { }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = S000000095Week10SchoolDB;";
            optionsBuilder.UseSqlServer(myconnectionstring);

            // Activity tracking code 
            ActivityAPIClient.Track(StudentID: "S00227213", StudentName: "Jack Monaghan",
                activityName: "RAD301 Week 10 Lab 2023", Task: "Adding Students with Registration Dates");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Read the student data from a CSV file and seed the database
            var students = Get<StudentMap, Student>(@"C:\Users\jackm\Desktop\RAD\rad301-labs-2023-2024-S00227213\Week10ClassLibraryS00227213\StudentList1.csv");
            modelBuilder.Entity<Student>().HasData(students.ToArray());
        }

        // This method reads the CSV data from a given file path
        public static List<T> Get<U, T>(string filePath) where U : ClassMap<T> where T : class
        {
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    HeaderValidated = null,
                    MissingFieldFound = null
                };

                CsvReader csvReader = new CsvReader(reader, configuration);
                csvReader.Context.RegisterClassMap<U>();
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
