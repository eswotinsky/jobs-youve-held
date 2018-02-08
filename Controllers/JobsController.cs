using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobHistory.Models;

namespace JobHistory.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Job> myJobHistory = Job.GetAll();
            return View(myJobHistory);
        }

        [HttpGet("/add")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpGet("/details/{id}")]
        public ActionResult Details(int id)
        {
            Job job = Job.Find(id);
            return View(job);
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Job newJob = new Job (Request.Form["title"], Request.Form["company"], Request.Form["dates"], Request.Form["description"]);
            List<Job> allJobs = Job.GetAll();
            return View("Index", allJobs);
        }
    }
}
