﻿using System.Diagnostics;
using _14CodeFirstEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace _14CodeFirstEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly HelloDbContext _dbContext;

        public HomeController(HelloDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var lst = _dbContext.employees.ToList();
            return View(lst);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _dbContext.employees.Add(emp);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var emp = _dbContext.employees.Find(id);
            return View(emp);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = _dbContext.employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            _dbContext.employees.Update(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = _dbContext.employees.Find(id);
            _dbContext.employees.Remove(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
