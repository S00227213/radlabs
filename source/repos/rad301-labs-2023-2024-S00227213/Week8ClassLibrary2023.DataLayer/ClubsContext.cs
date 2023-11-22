using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tracker.WebAPIClient;
using System;

namespace ClubModels
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }

        public ClubsContext(DbContextOptions<ClubsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(
                new Club { ClubId = 1, ClubName = "Basketball Club", CreationDate = DateTime.Now, adminID = 1 },
                new Club { ClubId = 2, ClubName = "Football Club", CreationDate = DateTime.Now, adminID = 2 },
                new Club { ClubId = 3, ClubName = "Boxing Club", CreationDate = DateTime.Now, adminID = 3 }
            );

            modelBuilder.Entity<ClubEvent>().HasData(
                new ClubEvent { EventID = 1, ClubId = 1, Venue = "National Basketball Arena", Location = "Tallaght, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(4) },
                new ClubEvent { EventID = 2, ClubId = 1, Venue = "Local Sports Center", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(45), EndDateTime = DateTime.Now.AddDays(45).AddHours(4) },
                new ClubEvent { EventID = 3, ClubId = 1, Venue = "City Arena", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(60), EndDateTime = DateTime.Now.AddDays(60).AddHours(4) },
                new ClubEvent { EventID = 4, ClubId = 1, Venue = "University Courts", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(75), EndDateTime = DateTime.Now.AddDays(75).AddHours(4) },
                new ClubEvent { EventID = 5, ClubId = 2, Venue = "Aviva Stadium", Location = "Ballsbridge, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(3) },
                new ClubEvent { EventID = 6, ClubId = 2, Venue = "Local Football Pitch", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(45), EndDateTime = DateTime.Now.AddDays(45).AddHours(3) },
                new ClubEvent { EventID = 7, ClubId = 2, Venue = "National Football Field", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(60), EndDateTime = DateTime.Now.AddDays(60).AddHours(3) },
                new ClubEvent { EventID = 8, ClubId = 2, Venue = "University Stadium", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(75), EndDateTime = DateTime.Now.AddDays(75).AddHours(3) },
                new ClubEvent { EventID = 9, ClubId = 3, Venue = "National Boxing Stadium", Location = "South Circular Road, Dublin", StartDateTime = DateTime.Now.AddDays(30), EndDateTime = DateTime.Now.AddDays(30).AddHours(2) },
                new ClubEvent { EventID = 10, ClubId = 3, Venue = "Downtown Boxing Gym", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(45), EndDateTime = DateTime.Now.AddDays(45).AddHours(2) },
                new ClubEvent { EventID = 11, ClubId = 3, Venue = "Local Gym", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(60), EndDateTime = DateTime.Now.AddDays(60).AddHours(2) },
                new ClubEvent { EventID = 12, ClubId = 3, Venue = "Community Center Arena", Location = "Dublin", StartDateTime = DateTime.Now.AddDays(75), EndDateTime = DateTime.Now.AddDays(75).AddHours(2) }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
