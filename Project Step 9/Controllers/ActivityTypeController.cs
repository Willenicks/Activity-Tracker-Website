using Microsoft.AspNetCore.Mvc;
using Project_Step_9.Models;

namespace Project_Step_9.Controllers
{
    public class ActivityTypeController : Controller
    {

        // Create 


        // Read


        public IActionResult Index()  // this displays everything from activity type
        {
            // Go to DB and get all activity types
            // Have  View list all the activity types
            return View();
        }


        public IActionResult Details(int id = 0)  // displays one value from activity type at a time 
        {
            // Go to DB in Models and get one activity type based on the ID receieved
            //Have the View display that reference 


            // Make a beginner Database

            ActivityType Running;
            Running = new ActivityType();
            Running.id = id;
            Running.userId = 1;
            Running.ActivityName = "Running";
            return View(Running);

        }

        // Update
        public IActionResult Goals(int id = 0)  // displays one value from activity type at a time 
        {
            //Go to DB and return an update

            ActivityType Running;
            Running = new ActivityType();
            Running.id = id;
            Running.userId = 1;
            Running.ActivityName = "Running";
            return View(Running);

        }

        // Delete


    }
}
