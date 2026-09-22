using Microsoft.AspNetCore.Mvc;
using TestDotnet.DB;
using TestDotnet.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestDotnet.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationContext _appcontext;
        public StudentsController(ApplicationContext applicationContext)
        {
            this._appcontext = applicationContext;
        }
        public IActionResult Index()
        {
            var studentData = _appcontext.Students.ToList();
            return View(studentData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Students students)
        {
            if (ModelState.IsValid)
            {
                var data = new Students
                {
                    Name = students.Name,
                    Email = students.Email,
                    Semester = students.Semester,
                    Cgpa = students.Cgpa,
                    package = students.package
                };
                _appcontext.Add(data);
                _appcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                return View(students);
            }
            
        }

        public IActionResult Delete(Guid Id)
        {
            var student = _appcontext.Students.SingleOrDefault(x => x.Id == Id);
            _appcontext.Remove(student);
            _appcontext?.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid Id)
        {
            var student = _appcontext.Students.SingleOrDefault(x => x.Id == Id);
            var data = new Students
            {
                Name = student.Name,
                Email = student.Email,
                Semester = student.Semester,
                Cgpa = student.Cgpa,
                package = student.package
            };
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Students students)
        {

            if (ModelState.IsValid)
            {
                var data = new Students
                {
                    Id = students.Id,
                    Name = students.Name,
                    Email = students.Email,
                    Semester = students.Semester,
                    Cgpa = students.Cgpa,
                    package = students.package
                };
                _appcontext.Update(data);
                _appcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(students);
            }
        }
    }
}
