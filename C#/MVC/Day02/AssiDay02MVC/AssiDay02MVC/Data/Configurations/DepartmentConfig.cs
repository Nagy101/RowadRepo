using AssiDay02MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssiDay02MVC.Data.Configurations
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            
            builder.Property(d => d.Name).IsRequired().HasMaxLength(50);
            
            builder.Property(d => d.MgrName).HasMaxLength(50);

            builder.HasMany(d => d.Teachers)
                   .WithOne(t=>t.Department)
                   .HasForeignKey(t => t.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.Courses)
                   .WithOne(c => c.Department)
                   .HasForeignKey(c => c.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(d => d.Students)
                   .WithOne(s => s.Department)
                   .HasForeignKey(s => s.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                        new Department
                        {
                            Id = 1,
                            Name = "CS",
                            MgrName = "Mohamed"
                        },
                        new Department
                        {
                            Id = 2,
                            Name = "IS",
                            MgrName = "Nagy"
                        });

        }
    }
}
