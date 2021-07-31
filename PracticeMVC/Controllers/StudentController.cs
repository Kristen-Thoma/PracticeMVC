using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Data;
using PracticeMVC.Models;
using PracticeMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMVC.Controllers
{
    public class StudentController : Controller
    {
        static private List<Student> Students = new List<Student>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddStudentViewModel addStudentViewModel = new AddStudentViewModel();

            return View(addStudentViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel addStudentViewModel)
        {
            Student newStudent = new Student
            {
                FirstName = addStudentViewModel.FirstName,
                LastName = addStudentViewModel.LastName,
                CareerPath = addStudentViewModel.CareerPath,
                JoinDate = addStudentViewModel.JoinDate
            };

            StudentData.Add(newStudent);

            return View(addStudentViewModel);
        }

        public IActionResult StudentInfo()
        {
            return View();
        }
    }

   
}
