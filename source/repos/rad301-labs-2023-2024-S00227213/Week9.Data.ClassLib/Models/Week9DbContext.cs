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
            ActivityAPIClient.Track(StudentID: "ppowell", 
                StudentName: "Paul Powell", 
                activityName: "RAD301 Week 9 Lab 2223", 
                Task: "Creating Clubs and Club Event tables");


            base.OnModelCreating(modelBuilder);
        }
    }
}
