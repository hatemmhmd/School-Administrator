using Microsoft.AspNetCore.Mvc;
using School_Administrator.Data;
using School_Administrator.Models;

namespace School_Administrator.Controllers
{
    public class StudentController : Controller
    {

        private AppDbContext _db;
        public StudentController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult AllResults()
        {
            IEnumerable<Student> StudentList = _db.Students.ToList();
            return View(StudentList);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(Student stu)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(stu);
                _db.SaveChanges();
                return RedirectToAction("AllResults");
            }

            else
            {
                return View(stu);
            }
        }



        [HttpGet]
        public IActionResult UpdateStudent(int? Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }

            var student = _db.Students.Find(Id);
            if(student == null) 
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateStudent(Student stu)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(stu);
                _db.SaveChanges();
                return RedirectToAction("AllResults");
            }

            else
            {
                return View(stu);
            }
        }



        public IActionResult DeleteStudent(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var student = _db.Students.Find(Id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(Student stu)
        {
                _db.Students.Remove(stu);
                _db.SaveChanges();
                return RedirectToAction("AllResults");


                
        }


    }
}
