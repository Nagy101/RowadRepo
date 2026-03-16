using AssiDay02MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssiDay02MVC.Data.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(t => t.Salary)
                   .HasColumnType("decimal(10,2)");

            builder.Property(t => t.Address)
                   .HasMaxLength(100);

            builder.HasOne(t => t.Department)
                   .WithMany(d => d.Teachers)
                   .HasForeignKey(t => t.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Course)
                   .WithMany(c => c.Teachers)
                   .HasForeignKey(t => t.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                            new Teacher
                            {
                                Id = 1,
                                Name = "Mohamed",
                                Salary = 8000,
                                Address = "Cairo",
                                DepartmentId = 1,
                                CourseId = 1
                            },
                            new Teacher
                            {
                                Id = 2,
                                Name = "Nagy",
                                Salary = 7500,
                                Address = "Giza",
                                DepartmentId = 1,
                                CourseId = 2
                            }
                        );
            }
    }
}
