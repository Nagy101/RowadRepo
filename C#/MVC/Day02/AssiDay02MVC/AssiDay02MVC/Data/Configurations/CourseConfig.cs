using AssiDay02MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssiDay02MVC.Data.Configurations
{
    public class CourseConfig : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.Degree)
                   .HasColumnType("decimal(5,2)");

            builder.Property(c => c.MinDegree)
                   .HasColumnType("decimal(5,2)");

            builder.HasOne(c => c.Department)
                   .WithMany(d => d.Courses)
                   .HasForeignKey(c => c.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                            new Courses
                            {
                                Id = 1,
                                Name = "Database",
                                Degree = 100,
                                MinDegree = 50,
                                DepartmentId = 1
                            },
                            new Courses
                            {
                                Id = 2,
                                Name = "Algorithms",
                                Degree = 100,
                                MinDegree = 50,
                                DepartmentId = 1
                            }
                        );
        }
    }
}
