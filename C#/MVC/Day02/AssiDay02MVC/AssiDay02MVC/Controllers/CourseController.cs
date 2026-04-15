using AssiDay02MVC.Data.Contexts;
using AssiDay02MVC.Models;
using AssiDay02MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssiDay02MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly CompanyDbContext _context = new CompanyDbContext();

        public IActionResult ShowAll()
        {
            var courses = _context.Courses.Include(c => c.Department).ToList();
            return View(courses);
        }

        public IActionResult ShowDetails(int id)
        {
            var course = _context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        public IActionResult Add()
        {
            var vm = new CourseDeptVM
            {
                Departments = _context.Departments.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CourseDeptVM vm)
        {
            if (vm.MinDegree > vm.Degree)
            {
                ModelState.AddModelError(nameof(vm.MinDegree), "Minimum degree must be less than or equal to degree.");
            }

            if (!ModelState.IsValid)
            {
                vm.Departments = _context.Departments.ToList();
                return View(vm);
            }

            var course = new Courses
            {
                Name = vm.Name,
                Degree = vm.Degree,
                MinDegree = vm.MinDegree,
                DepartmentId = vm.DepartmentId
            };

            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(ShowAll));
        }

        public IActionResult Edit(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
            {
                return NotFound();
            }

            var vm = new CourseDeptVM
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                DepartmentId = course.DepartmentId,
                Departments = _context.Departments.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CourseDeptVM vm)
        {
            if (vm.MinDegree > vm.Degree)
            {
                ModelState.AddModelError(nameof(vm.MinDegree), "Minimum degree must be less than or equal to degree.");
            }

            if (!ModelState.IsValid)
            {
                vm.Departments = _context.Departments.ToList();
                return View(vm);
            }

            var course = _context.Courses.Find(vm.Id);
            if (course == null)
            {
                return NotFound();
            }

            course.Name = vm.Name;
            course.Degree = vm.Degree;
            course.MinDegree = vm.MinDegree;
            course.DepartmentId = vm.DepartmentId;

            _context.SaveChanges();
            return RedirectToAction(nameof(ShowAll));
        }

        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var course = _context.Courses.Include(c => c.StuCrs).FirstOrDefault(c => c.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            if (course.StuCrs != null && course.StuCrs.Any())
            {
                _context.StuCrs.RemoveRange(course.StuCrs);
            }

            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(ShowAll));
        }

        public IActionResult StudentCourseDegree(int studentId, int courseId)
        {
            var studentCourse = _context.StuCrs
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                .FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);

            if (studentCourse == null || studentCourse.Student == null || studentCourse.Course == null)
            {
                return NotFound();
            }

            var isPassed = studentCourse.Grade >= studentCourse.Course.MinDegree;
            var vm = new StudentCourseDegreeVM
            {
                StudentName = studentCourse.Student.Name,
                CourseName = studentCourse.Course.Name,
                Degree = studentCourse.Grade,
                ResultText = isPassed ? "Passed" : "Failed",
                ResultClass = isPassed ? "text-success" : "text-danger"
            };

            return View(vm);
        }
    }
}
