using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tracker.WebAPIClient;
using System;

namespace ClubModels
{
    
    public class Week9DbContext : IdentityDbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }

        public Week9DbContext(DbContextOptions<Week9DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

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

            
            ActivityAPIClient.Track(StudentID: "s00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 9 Lab 2223", Task: "Implementing Partial Views");
        }
    }
}
