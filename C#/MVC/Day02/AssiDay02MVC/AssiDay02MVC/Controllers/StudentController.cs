using AssiDay02MVC.Data.Contexts;
using AssiDay02MVC.Models;
using AssiDay02MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssiDay02MVC.Controllers
{
    public class StudentController : Controller
    {
        CompanyDbContext _context = new CompanyDbContext();

        public IActionResult ShowAll(string search, int? departmentId, int page = 1, int pageSize = 10)
        {
            var query = _context.Students.Include(s => s.Department).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(s => s.Name.Contains(search));
            }

            if (departmentId.HasValue)
            {
                query = query.Where(s => s.DepartmentId == departmentId);
            }

            var totalStudents = query.Count();
            var students = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var vm = new StudentShowAllVM
            {
                Students = students,
                Departments = _context.Departments.ToList(),
                Search = search,
                DepartmentId = departmentId,
                TotalPages = (int)Math.Ceiling(totalStudents / (double)pageSize),
                CurrentPage = page
            };

            return View(vm);
        }
        public IActionResult ShowDetails(int id)
        {
            var student = _context.Students
                                  .Include(s => s.Department)
                                  .Include(s => s.StuCrs)
                                  .ThenInclude(sc => sc.Course)
                                  .FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }
       
        public IActionResult Add()
        {
            var vm = new StudentDeptVM()
            {
                Departments = _context.Departments.ToList()
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Add(StudentDeptVM vm)
        {
            if (ModelState.IsValid)
            {
                var student = new Student()
                {
                    Name = vm.Name,
                    Age = vm.Age,
                    DepartmentId = vm.DepartmentId
                };

                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("ShowAll");
            }

            vm.Departments = _context.Departments.ToList();
            return View(vm);
        }
        
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            var vm = new StudentDeptVM
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                Departments = _context.Departments.ToList()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(StudentDeptVM vm)
        {
            if (ModelState.IsValid)
            {
                var student = _context.Students.Find(vm.Id);
                if (student == null)
                {
                    return NotFound();
                }

                student.Name = vm.Name;
                student.Age = vm.Age;
                student.DepartmentId = vm.DepartmentId;

                _context.SaveChanges();
                return RedirectToAction("ShowAll");
            }

            vm.Departments = _context.Departments.ToList();
            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            var student = _context.Students
                                  .Include(s => s.Department)
                                  .FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var student = _context.Students
                                  .Include(s => s.StuCrs)  
                                  .FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            if (student.StuCrs != null && student.StuCrs.Any())
            {
                _context.StuCrs.RemoveRange(student.StuCrs);
            }
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("ShowAll");
        }
    }
}
