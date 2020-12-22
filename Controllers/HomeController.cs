using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Students.Models;
using Students.ViewModel;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        db_StudentRegistrationEntities db = new db_StudentRegistrationEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //add new student
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(student student)
        {
            if (ModelState.IsValid)
            {
                tbl_Students students = new tbl_Students();
                students.studentFirstName = student.studentFirstName;
                students.studentLastName = student.studentLastName;
                students.studentDOB = Convert.ToDateTime(student.studentDOB);
                students.Address = student.Address;
                db.tbl_Students.Add(students);
                db.SaveChanges();
                return RedirectToAction("Index","home");
            }
            
            return View();
        }
        public JsonResult getData()
        {

            var GetStudent = db.tbl_Students.
                Select(w => new GetStudent
                {
                    studentFirstName=w.studentFirstName,
                    studentLastName=w.studentLastName,
                    studentDOB=w.studentDOB.ToString(),
                    age= w.age.ToString()
                });

            return Json(GetStudent, JsonRequestBehavior.AllowGet);
        }

        public class GetStudent
        {
            public int studentId { get; set; }
            public string studentFirstName { get; set; }
            public string studentLastName { get; set; }
            public string studentDOB { get; set; }
            public string age { get; set; }
        }
    }
}