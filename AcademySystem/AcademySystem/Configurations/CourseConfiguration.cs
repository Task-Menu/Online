using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademySystem.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");

            builder.HasMany(c => c.MentorCourses)
                .WithOne(t => t.Courses)
                .HasForeignKey(x => x.CourseId);

            builder.Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(x => x.Price)
                .HasPrecision(10, 2)
                .IsRequired();
            builder.Property(x => x.Rating)
                .HasPrecision(10, 2)
                .IsRequired();
        }
    }
}
