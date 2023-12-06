using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClubModels;
using Tracker.WebAPIClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class ClubEventsController : Controller
{
    private readonly ClubsContext db;

    public ClubEventsController(ClubsContext context)
    {
        db = context;
    }

    // GET: ClubEvents
    public async Task<ActionResult> Index()
    {
        ActivityAPIClient.Track(StudentID: "S00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Accessing Index View");
        ViewBag.Clubs = await FillClubs();
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Index(Club model)
    {
        ViewBag.Clubs = await FillClubs();
        if (model.ClubId == 0)
        {
            ModelState.AddModelError("ClubId", "Please select a club.");
            return View();
        }

        var clubDetails = await db.Clubs.Include(c => c.ClubEvents).FirstOrDefaultAsync(c => c.ClubId == model.ClubId);
        if (clubDetails == null)
        {
            ModelState.AddModelError("ClubId", "The selected club does not exist.");
            return View();
        }

        return View("Details", clubDetails);
    }

    private async Task<IEnumerable<SelectListItem>> FillClubs()
    {
        var clubs = await db.Clubs.ToListAsync();
        return clubs.Select(c => new SelectListItem
        {
            Value = c.ClubId.ToString(),
            Text = c.ClubName
        });
    }

    public async Task<ActionResult> AllClubDetails(string ClubName = null)
    {
        ActivityAPIClient.Track(StudentID: "S00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Implementing All Club Detail Filter");
        var fullClub = await db.Clubs
            .Include(c => c.ClubEvents)
            .Where(c => ClubName == null || c.ClubName.StartsWith(ClubName))
            .ToListAsync();
        return View(fullClub);
    }
}
