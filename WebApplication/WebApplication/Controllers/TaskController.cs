using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel() {TaskId = 1,TaskName = "Nauka C#", Description = "Ucz sie pilnie",Done = false},
            new TaskModel() {TaskId = 2,TaskName = "Nauka C# i .NET", Description = "Ucz sie pilnie",Done = false},
            new TaskModel() {TaskId = 3,TaskName = "Nauka MVC ASP .NET", Description = "Ucz sie pilnie",Done = false},
            new TaskModel() {TaskId = 4,TaskName = "Nauka C#", Description = "Ucz sie pilnie",Done = false},
            new TaskModel() {TaskId = 5,TaskName = "Nauka C#", Description = "Ucz sie pilnie",Done = false}

        };

        // GET: Task
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            try
            {
                taskModel.TaskId = tasks.Count + 1;
                tasks.Add(taskModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}