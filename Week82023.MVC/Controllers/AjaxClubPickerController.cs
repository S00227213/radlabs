using Microsoft.AspNetCore.Mvc;
using ClubModels;
using Tracker.WebAPIClient; 
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering; 

// Define the AjaxClubPickerController
public class AjaxClubPickerController : Controller
{
    // Initialize the ClubsContext
    ClubsContext db = new ClubsContext();

    // Define the Index action
    public ActionResult Index()
    {
       
        ActivityAPIClient.Track(
            StudentID: "S00227213", 
            StudentName: "Jack Monaghan", 
            activityName: "RAD301 Week 11 Lab 2023",
            Task: "Implementing Ajax club picker"
        );

        // Prepare the ViewBag with club list items for the dropdown
        ViewBag.clubList = new SelectList(db.Clubs, "ClubId", "ClubName");

        // Return the Index view
        return View();
    }
}
