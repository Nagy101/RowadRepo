using AssiDay02MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssiDay02MVC.Data.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                            new Student
                            {
                                Id = 1,
                                Name = "Ali",
                                Age = 21,
                                DepartmentId = 1
                            },
                            new Student
                            {
                                Id = 2,
                                Name = "Omar",
                                Age = 22,
                                DepartmentId = 1
                            },
                            new Student
                            {
                                Id = 3,
                                Name = "Mostafa",
                                Age = 20,
                                DepartmentId = 2
                            }
                        );
                                }
    }
}
