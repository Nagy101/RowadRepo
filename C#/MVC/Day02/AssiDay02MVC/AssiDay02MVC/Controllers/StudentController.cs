using AssiDay02MVC.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssiDay02MVC.Controllers
{
    public class StudentController : Controller
    {
        public CompanyDbContext Context = new CompanyDbContext();
        public IActionResult Index()
        {
            return View("ShowAll");
        }
        public IActionResult ShowAll()
        {
            var students = Context.Students.Include(s=>s.Department).ToList();
            return View(students);
        }
        public IActionResult ShowDetails(int Id)
        {
            var student = Context.Students.Include(s=>s.Department)
                                           .Include(s=>s.StuCrs)
                                           .ThenInclude(sc => sc.Course)
                                           .FirstOrDefault(s => s.Id == Id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);   
        }

    }
}
