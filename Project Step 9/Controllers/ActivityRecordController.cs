using Microsoft.AspNetCore.Mvc;
using Project_Step_9.Models;

namespace Project_Step_9.Controllers
{
    public class ActivityRecordController : Controller
    {
        // Methods


        // Create

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ActivityRecord a)
        {
            return RedirectToAction("Details");  //This adds activityrecord a to db
        }

        // Read
        //Read an activity out of a db and display it on web page
        public IActionResult Details(int id)
        {
            // 1. Go to DB and retrieve activity with the given id
            ActivityRecord a = new ActivityRecord();
            a.RecordID = 1;
            a.ActivityId = 3;
            a.Date = "2 May 2020";
            a.Distance = 20;
            a.Location = "Colorado Springs";
            a.TimeRecord = "2 hrs";

            // 2. Display that activity on a View
            return View(a);
        }


        // Update

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //1. Read an activity out of a db 

            ActivityRecord a = new ActivityRecord();
            a.RecordID = 1;
            a.ActivityId = 3;
            a.Date = "2 May 2020";
            a.Distance = 20;
            a.Location = "Colorado Springs";
            a.TimeRecord = "2 hrs";

            //2. display it so user can change some fields 

            return View(a);
        }

        [HttpPost]
        public IActionResult Edit(ActivityRecord a)
        {
            // Update the activity record (a) in the DB
            return RedirectToAction("Details");  
        }




        //Delete

    }
}
