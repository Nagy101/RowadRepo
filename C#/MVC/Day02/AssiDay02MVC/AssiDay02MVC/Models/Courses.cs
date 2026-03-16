using System.ComponentModel.DataAnnotations.Schema;

namespace AssiDay02MVC.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Degree { get; set; }
        public decimal MinDegree { get; set; } = 50;
        public List<Teacher>? Teachers { get; set; } 
        public List<StuCrsRes>? StuCrs { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
