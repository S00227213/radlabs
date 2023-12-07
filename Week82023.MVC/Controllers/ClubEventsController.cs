using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClubModels; // Ensure this namespace contains your Club and ClubEvent models
using Tracker.WebAPIClient; // Ensure this namespace contains the ActivityAPIClient
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering; // Used for generating the SelectListItems for dropdowns
using System.Collections.Generic; // Used for collections like List and IEnumerable

public class ClubEventsController : Controller
{
    private readonly ClubsContext db; // Database context for EF Core operations

    public ClubEventsController(ClubsContext context)
    {
        db = context; // Dependency injection of database context
    }

    // GET: ClubEvents
    public async Task<ActionResult> Index()
    {
        // Tracking student activity
        ActivityAPIClient.Track(StudentID: "S00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Accessing Index View");
        // Filling the Clubs dropdown
        ViewBag.Clubs = await FillClubs();
        return View(); // Returning the Index view
    }

    [HttpPost]
    public async Task<ActionResult> Index(Club model)
    {
        // Filling the Clubs dropdown
        ViewBag.Clubs = await FillClubs();
        if (model.ClubId == 0)
        {
            // Adding a model error if no club is selected
            ModelState.AddModelError("ClubId", "Please select a club.");
            return View(); // Returning the view with errors
        }

        // Getting the details of the selected club
        var clubDetails = await db.Clubs.Include(c => c.clubEvents).FirstOrDefaultAsync(c => c.ClubId == model.ClubId);
        if (clubDetails == null)
        {
            // Adding a model error if the selected club doesn't exist
            ModelState.AddModelError("ClubId", "The selected club does not exist.");
            return View(); // Returning the view with errors
        }

        return View("Details", clubDetails); // Returning the Details view with club details
    }

    // Utility method to fill clubs for dropdown
    private async Task<IEnumerable<SelectListItem>> FillClubs()
    {
        var clubs = await db.Clubs.ToListAsync();
        // Projecting each club into a SelectListItem
        return clubs.Select(c => new SelectListItem
        {
            Value = c.ClubId.ToString(),
            Text = c.ClubName
        });
    }

    // Method to handle the club details filtering
    public async Task<ActionResult> AllClubDetails(string ClubName = null)
    {
        // Tracking student activity
        ActivityAPIClient.Track(StudentID: "S00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Implementing All Club Detail Filter");
        // Querying the full club details with optional filtering by ClubName
        var fullClub = await db.Clubs
            .Include(c => c.clubEvents)
            .Where(c => ClubName == null || c.ClubName.StartsWith(ClubName))
            .ToListAsync();
        return View(fullClub); // Returning the view with the query result
    }

    // New method to handle Ajax request for club events
    public async Task<PartialViewResult> _ClubEvents(int id)
    {
        // Querying the events for a particular club
        var qry = await db.ClubEvents.Where(ce => ce.ClubId == id).ToListAsync();
        return PartialView(qry); // Returning the partial view with the query result
    }
}
