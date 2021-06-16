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
            string title = "Simple Task Manager";
            return View(tasks);
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
      
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
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
                return View(tasks);
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            try
            {
                TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
                task.TaskName = taskModel.TaskName;
                task.Description = taskModel.Description;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

     
        public ActionResult Delete(int id)
        {
           
            return View(tasks.FirstOrDefault(x => x.TaskId == id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            try
            {
                TaskModel task = tasks.FirstOrDefault(x => x.TaskId == id);
                tasks.Remove(task);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}