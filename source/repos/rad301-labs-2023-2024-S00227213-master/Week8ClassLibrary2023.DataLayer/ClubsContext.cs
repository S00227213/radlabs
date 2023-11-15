using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using Tracker.WebAPIClient;

namespace ClubModels
{
    public class ClubsContext : DbContext
    {
        
        public ClubsContext(DbContextOptions<ClubsContext> options) : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var myconnectionstring = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=rad301labs20232024; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                optionsBuilder.UseSqlServer(myconnectionstring)
                    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
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
            // Seeding the database with club events, using StartDateTime and EndDateTime to specify when the events begin and end
            modelBuilder.Entity<ClubEvent>().HasData(
                new ClubEvent { EventID = 1, ClubId = 1, Venue = "National Basketball Arena", Location = "Tallaght, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(4) },
                new ClubEvent { EventID = 2, ClubId = 2, Venue = "Aviva Stadium", Location = "Ballsbridge, Dublin", StartDateTime = DateTime.Now.AddDays(60), EndDateTime = DateTime.Now.AddDays(60).AddHours(3) },
                new ClubEvent { EventID = 3, ClubId = 3, Venue = "National Boxing Stadium", Location = "South Circular Road, Dublin", StartDateTime = DateTime.Now.AddDays(90), EndDateTime = DateTime.Now.AddDays(90).AddHours(2) }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}