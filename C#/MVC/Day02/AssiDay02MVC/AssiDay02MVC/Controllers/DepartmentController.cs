using AssiDay02MVC.Data.Contexts;
using AssiDay02MVC.Models;
using AssiDay02MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssiDay02MVC.Controllers
{
    public class DepartmentController : Controller
    {
        public CompanyDbContext Context = new CompanyDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            return View(Context.Departments.ToList());
        }

        public IActionResult ShowDetails(int id)
        {
            var department = Context.Departments
                                    .Include(d => d.Teachers)
                                    .Include(d => d.Courses)
                                    .Include(d => d.Students)
                                    .FirstOrDefault(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                Context.Departments.Add(department);
                Context.SaveChanges();
                return RedirectToAction("ShowAll");
            }
            return View(department);
        }

        public IActionResult DeptWithStudents(int id)
        {
            var dept = Context.Departments
                .Include(d => d.Students)
                .FirstOrDefault(d => d.Id == id);

            if (dept == null)
                return NotFound();

            var students = dept.Students
                .Where(s => s.Age > 25)
                .ToList();

            string state = students.Count > 50 ? "Main" : "Branch";

            var vm = new DepartmentDetailsVM
            {
                DepartmentName = dept.Name,
                Students = students,
                DepartmentState = state
            };

            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            var department = Context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                var existingDepartment = Context.Departments.Find(department.Id);
                if (existingDepartment == null)
                {
                    return NotFound();
                }

                existingDepartment.Name = department.Name;
                existingDepartment.MgrName = department.MgrName;

                Context.SaveChanges();
                return RedirectToAction("ShowAll");
            }

            return View(department);
        }
    }
}
