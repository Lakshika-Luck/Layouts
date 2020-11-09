using LayoutView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private CampusContext campusContext = new CampusContext();
        public ActionResult Index()
        {
            List<Student> Allstudents = campusContext.Students.ToList();
            return View(Allstudents);
        }

        public ActionResult Details(String id)
        {
            Student student = campusContext.Students.SingleOrDefault(x => x.Regno == id);
            return View(student);
        }

        public ActionResult Create()
        {
            return View("Create", "AdLayout");  //specified to use AdLayout
        }
        public ActionResult AllStudents()
        {
            List<Student> Allstudents = campusContext.Students.ToList();
            return View(Allstudents);
        }
    }
}