using AssiDay02MVC.Models;

namespace AssiDay02MVC.ViewModel
{
    public class StudentShowAllVM
    {
        public List<Student> Students { get; set; } = new();
        public List<Department> Departments { get; set; } = new();
        public string? Search { get; set; }
        public int? DepartmentId { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
