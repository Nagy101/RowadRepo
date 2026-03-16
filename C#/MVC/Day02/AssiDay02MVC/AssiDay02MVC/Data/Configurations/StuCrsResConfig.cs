using AssiDay02MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssiDay02MVC.Data.Configurations
{
    public class StuCrsResConfig : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Property(sc => sc.Grade)
                   .HasColumnType("decimal(5,2)");

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.StuCrs)
                   .HasForeignKey(sc => sc.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StuCrs)
                   .HasForeignKey(sc => sc.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);



            builder.HasData(
                        new StuCrsRes
                        {
                            StudentId = 1,
                            CourseId = 1,
                            Grade = 85
                        },
                        new StuCrsRes
                        {
                            StudentId = 2,
                            CourseId = 1,
                            Grade = 90
                        },
                        new StuCrsRes
                        {
                            StudentId = 3,
                            CourseId = 2,
                            Grade = 78
                        }
                    );
        }
    }
}
