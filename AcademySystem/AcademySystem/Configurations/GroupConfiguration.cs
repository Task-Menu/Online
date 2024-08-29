using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademySystem.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Gruop>
    {
        public void Configure(EntityTypeBuilder<Gruop> builder)
        {
            builder.ToTable("Groups");

            builder.HasMany(g => g.Enrollments)
                .WithOne(t => t.Group)
                .HasForeignKey(x => x.GroupId);

            builder.HasOne(g => g.MentorCourses)
                .WithMany(t => t.Groups)
                .HasForeignKey(x => x.MentorCourseId);
        }
    }
}
