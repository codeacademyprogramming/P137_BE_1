using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstApp.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> _students;
        public StudentController()
        {
            _students = new List<Student>()
            {
                new Student{Id=1,FullName = "Hikmet Abbasov",Age=23,Point=55},
                new Student{Id=2,FullName = "Tofiq Abbasov",Age=29,Point=94},
                new Student{Id=3,FullName = "Nermin Abbasova",Age=33,Point=15},
                new Student{Id=4,FullName = "Nigar Abbaszade",Age=43,Point=76},
            };
        }

        public IActionResult Index()
        {
            ViewBag.Students = _students;

            return View();
        }

        public IActionResult Info(int id)
        {
            var student = _students.Find(x=>x.Id == id);

            if (student == null)
                return View("error");

            ViewBag.Student = student;

            return View();
        }


        public IActionResult Detail(string name,string surname,int age)
        {
            //return Content($"FullName: {name} {surname} - Age: {age}");

            ViewData["name"] = name;
            ViewBag.Surname = surname;
            TempData["age"] = age;

            //return View();
            return RedirectToAction("ShowStudent");
        }

        public IActionResult ShowStudent()
        {
            var age = TempData["age"];
            return View("Detail");
        }

      
    }
}
