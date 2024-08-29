using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademySystem.Configurations
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Enrollment");

            builder.HasOne(g => g.Group)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(x => x.GroupId);

            builder.HasOne(g => g.Student)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(x => x.StudentId);
        }
    }
}
