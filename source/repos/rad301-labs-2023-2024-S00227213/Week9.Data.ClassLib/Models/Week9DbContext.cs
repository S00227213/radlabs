using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tracker.WebAPIClient;

namespace ClubModels
{
    public class Week9DbContext : DbContext
    {

        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }

        public Week9DbContext()
            : base()
        {
        }

        public static Week9DbContext Create()
        {
            return new Week9DbContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Week9DB-PPOWELL";
            optionsBuilder.UseSqlServer(myconnectionstring)
            //optionsBuilder.UseSqlServer()
              .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information).
                        EnableSensitiveDataLogging(true);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(
                new Club { ClubId = 1, ClubName = "Chess Club", CreationDate = new DateTime(2022, 1, 1), adminID = 100 },
                new Club { ClubId = 2, ClubName = "Book Club", CreationDate = new DateTime(2022, 2, 1), adminID = 101 },
                new Club { ClubId = 3, ClubName = "Coding Club", CreationDate = new DateTime(2022, 3, 1), adminID = 102 }
            );

            modelBuilder.Entity<ClubEvent>().HasData(
                new ClubEvent { EventID = 1, ClubId = 1, Venue = "Library", Location = "Room 101", StartDateTime = new DateTime(2022, 4, 1, 14, 0, 0), EndDateTime = new DateTime(2022, 4, 1, 16, 0, 0) },
                new ClubEvent { EventID = 2, ClubId = 2, Venue = "Community Hall", Location = "Main Hall", StartDateTime = new DateTime(2022, 5, 1, 13, 0, 0), EndDateTime = new DateTime(2022, 5, 1, 15, 0, 0) },
                new ClubEvent { EventID = 3, ClubId = 3, Venue = "Tech Center", Location = "Lab A", StartDateTime = new DateTime(2022, 6, 1, 18, 0, 0), EndDateTime = new DateTime(2022, 6, 1, 20, 0, 0) }
            );

            // Tracking code updated with your ID and name
            ActivityAPIClient.Track(StudentID: "s00227213",
                StudentName: "Jack Monaghan",
                activityName: "RAD301 Week 9 Lab 2223",
                Task: "Seeding Clubs and Club Event tables");

            base.OnModelCreating(modelBuilder);
        }


    }
}