using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;

namespace TechJobPortal.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            var jobs = new List<JobListing>
            {
                new JobListing { Id = 1, Title = "Software Developer", CompanyName = "Apple", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-2) },
                new JobListing { Id = 2, Title = "Data Analyst", CompanyName = "Microsoft", Location = "Jeddah", JobType = JobType.Remote, PostedDate = DateTime.Now.AddDays(-5) },
                new JobListing { Id = 3, Title = "Web Designer", CompanyName = "Google", Location = "Madinah", JobType = JobType.Contract, PostedDate = DateTime.Now.AddDays(-10) },
        
            };
            return View(jobs);
        }

        public IActionResult Details(int id)
        {
            var job = new JobListing { Id = id, Title = "Software Developer", CompanyName = "Apple", Location = "Riyadh", JobType = JobType.FullTime, PostedDate = DateTime.Now.AddDays(-2) };
            return View(job);
        }
    }
}
