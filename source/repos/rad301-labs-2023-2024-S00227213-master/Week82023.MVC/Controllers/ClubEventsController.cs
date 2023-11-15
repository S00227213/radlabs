using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClubModels;
using System.Threading.Tasks;
using Tracker.WebAPIClient;

public class ClubEventsController : Controller
{
    private readonly ClubsContext _db;

    public ClubEventsController(ClubsContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        
        var clubs = await _db.Clubs.ToListAsync();
        return View(clubs);
    }

    // This action returns a view with a detailed list of clubs and their events.
    public async Task<IActionResult> AllClubDetails(string clubName = null)
    {
        
        ActivityAPIClient.Track(StudentID: "s00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Creating Customized Views");

        ViewBag.clubName = clubName;
        var fullClub = await _db.Clubs
            .Include(c => c.clubEvents) 
            .Where(c => clubName == null || c.ClubName.StartsWith(clubName))
            .ToListAsync();

        return View(fullClub); 
    }
}
