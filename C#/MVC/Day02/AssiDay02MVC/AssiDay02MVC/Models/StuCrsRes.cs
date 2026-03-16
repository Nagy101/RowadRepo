using System.ComponentModel.DataAnnotations.Schema;

namespace AssiDay02MVC.Models
{
    public class StuCrsRes
    {
        public int CourseId { get; set; }
        public Courses? Course { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public decimal Grade { get; set; }
    }
}
