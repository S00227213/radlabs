using Microsoft.AspNetCore.Mvc;
using ClubModels;
using Tracker.WebAPIClient;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

public class AjaxClubPickerController : Controller
{
    private readonly ClubsContext db;

    // Dependency injection of ClubsContext
    public AjaxClubPickerController(ClubsContext context)
    {
        db = context;
    }

    public ActionResult Index()
    {
        ActivityAPIClient.Track(
            StudentID: "S00227213",
            StudentName: "Jack Monaghan",
            activityName: "RAD301 Week 11 Lab 2023",
            Task: "Implementing Ajax club picker"
        );

        ViewBag.clubList = new SelectList(db.Clubs, "ClubId", "ClubName");
        return View();
    }
}
