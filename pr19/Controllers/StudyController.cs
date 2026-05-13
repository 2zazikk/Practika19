using Microsoft.AspNetCore.Mvc;
using pr19.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pr19.Controllers
{
    public class StudyController : Controller
    {
        private static List<StudyTask> tasks =
            new List<StudyTask>()
        {
            new StudyTask
            {
                Subject = "Математика",
                Deadline = DateTime.Now.AddDays(2),
                Completed = false
            },

            new StudyTask
            {
                Subject = "Физика",
                Deadline = DateTime.Now.AddDays(5),
                Completed = true
            }
        };

        // /Study/Upcoming
        public IActionResult Upcoming()
        {
            var sortedTasks = tasks
                .OrderBy(t => t.Deadline)
                .ToList();

            return View(sortedTasks);
        }

        [HttpPost]
        public IActionResult Add(StudyTask task)
        {
            task.Completed = false;

            tasks.Add(task);

            return RedirectToAction("Upcoming");
        }
    }
}