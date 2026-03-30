using AssiDay02MVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AssiDay02MVC.ViewModel
{
    public class StudentDeptVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int DepartmentId { get; set; }
        [ValidateNever]
        public List<Department> Departments { get; set; }
        public List<StuCrsRes> ? StuCrs { get; set; }
    }
}
