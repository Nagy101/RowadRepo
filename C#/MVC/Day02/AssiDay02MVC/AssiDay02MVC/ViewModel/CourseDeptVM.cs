using AssiDay02MVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace AssiDay02MVC.ViewModel
{
    public class CourseDeptVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 999.99)]
        public decimal Degree { get; set; }

        [Range(0, 999.99)]
        public decimal MinDegree { get; set; } = 50;

        [Required]
        public int? DepartmentId { get; set; }

        [ValidateNever]
        public List<Department> Departments { get; set; } = new();
    }
}
