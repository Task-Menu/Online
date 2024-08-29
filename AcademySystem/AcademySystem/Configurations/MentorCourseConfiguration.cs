using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademySystem.Configurations
{
    public class MentorCourseConfiguration : IEntityTypeConfiguration<MentorCourse>
    {
        public void Configure(EntityTypeBuilder<MentorCourse> builder)
        {
            builder.ToTable("MentorCourse");

            builder.HasOne(m => m.Mentor)
                .WithMany(t => t.MentorCourses)
                .HasForeignKey(x => x.MentorId);
            builder.HasOne(m => m.Courses)
                .WithMany(t => t.MentorCourses)
                .HasForeignKey(x => x.CourseId);

            builder.HasMany(m => m.Groups)
                .WithOne(t => t.MentorCourses)
                .HasForeignKey(x => x.MentorCourseId);
        }
    }
}
