using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using Tracker.WebAPIClient;

namespace ClubModels
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public ClubsContext()
            : base()
        {
        }

        public static ClubsContext Create()
        {
            return new ClubsContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Week8DB-S00227213";
            optionsBuilder.UseSqlServer(myconnectionstring)
              .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information).
                        EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ActivityAPIClient.Track(StudentID: "S00227213",
                StudentName: "Jack Monaghan",
                activityName: "RAD301 Week 8 Lab 2023",
                Task: "Adding Club Events");

            // Seeding the database with clubs
            modelBuilder.Entity<Club>().HasData(
                new Club { ClubId = 1, ClubName = "Basketball Club", CreationDate = DateTime.Now, adminID = 1 },
                new Club { ClubId = 2, ClubName = "Football Club", CreationDate = DateTime.Now, adminID = 2 },
                new Club { ClubId = 3, ClubName = "Boxing Club", CreationDate = DateTime.Now, adminID = 3 }
            );

            // Seeding the database with club events for each club
            modelBuilder.Entity<ClubEvent>().HasData(
                // Basketball Club Events
                new ClubEvent { EventID = 1, ClubId = 1, Venue = "National Basketball Arena", Location = "Tallaght, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(4) },
                new ClubEvent { EventID = 2, ClubId = 1, Venue = "Local Sports Hall", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(45), EndDateTime = DateTime.Now.AddDays(45).AddHours(3) },
                new ClubEvent { EventID = 3, ClubId = 1, Venue = "Community Center", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(60), EndDateTime = DateTime.Now.AddDays(60).AddHours(2) },
                new ClubEvent { EventID = 4, ClubId = 1, Venue = "University Sports Complex", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(75), EndDateTime = DateTime.Now.AddDays(75).AddHours(3) },

                // Football Club Events
                new ClubEvent { EventID = 5, ClubId = 2, Venue = "Aviva Stadium", Location = "Ballsbridge, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(3) },
                new ClubEvent { EventID = 6, ClubId = 2, Venue = "Local Football Field", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(50), EndDateTime = DateTime.Now.AddDays(50).AddHours(2) },
                new ClubEvent { EventID = 7, ClubId = 2, Venue = "High School Stadium", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(70), EndDateTime = DateTime.Now.AddDays(70).AddHours(3) },
                new ClubEvent { EventID = 8, ClubId = 2, Venue = "City Park Arena", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(90), EndDateTime = DateTime.Now.AddDays(90).AddHours(2) },

                // Boxing Club Events
                new ClubEvent { EventID = 9, ClubId = 3, Venue = "National Boxing Stadium", Location = "South Circular Road, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(2) },
                new ClubEvent { EventID = 10, ClubId = 3, Venue = "Downtown Gym", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(55), EndDateTime = DateTime.Now.AddDays(55).AddHours(3) },
                new ClubEvent { EventID = 11, ClubId = 3, Venue = "Local Fitness Center", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(80), EndDateTime = DateTime.Now.AddDays(80).AddHours(2) },
                new ClubEvent { EventID = 12, ClubId = 3, Venue = "University Sports Hall", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(105), EndDateTime = DateTime.Now.AddDays(105).AddHours(3) }
            );

           

            base.OnModelCreating(modelBuilder);
        }


    }
}