using AssiDay02MVC.Models;

namespace AssiDay02MVC.ViewModel
{
    public class DepartmentDetailsVM
    {
        public string DepartmentName { get; set; }

        public List<Student>? Students { get; set; }

        public int? SelectedStudentId { get; set; }

        public string DepartmentState { get; set; }
    }
}
