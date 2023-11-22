using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubModels; 
using System.Threading.Tasks;
using Tracker.WebAPIClient;
using System.Linq; 

public class ClubEventsController : Controller
{
    private readonly ClubsContext _db;

    public ClubEventsController(ClubsContext db)
    {
        _db = db;
    }

    private List<SelectListItem> FillClubs()
    {
        var items = new List<SelectListItem>();
        var clubs = _db.Clubs.ToList();
        foreach (var item in clubs)
        {
            items.Add(new SelectListItem { Value = item.ClubId.ToString(), Text = item.ClubName });
        }
        return items;
    }

    public IActionResult Index()
    {
        ActivityAPIClient.Track(StudentID: "s00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2023", Task: "Implementing Drop-Down List");

        ViewBag.Clubs = FillClubs();
        return View();
    }

    [HttpPost]
    public IActionResult Index(Club model)
    {
        ViewBag.Clubs = FillClubs();
        var selectedClub = _db.Clubs.FirstOrDefault(c => c.ClubId == model.ClubId);
        
        return View(selectedClub);
    }

   
}
