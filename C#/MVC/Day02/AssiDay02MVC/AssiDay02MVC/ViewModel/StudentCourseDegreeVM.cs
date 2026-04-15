namespace AssiDay02MVC.ViewModel
{
    public class StudentCourseDegreeVM
    {
        public string StudentName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public decimal Degree { get; set; }
        public string ResultText { get; set; } = string.Empty;
        public string ResultClass { get; set; } = string.Empty;
    }
}
