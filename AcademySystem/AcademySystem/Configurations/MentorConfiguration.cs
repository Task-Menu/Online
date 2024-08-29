using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademySystem.Configurations
{
    public class MentorConfiguration : IEntityTypeConfiguration<Mentor>
    {
        public void Configure(EntityTypeBuilder<Mentor> builder)
        {
            builder.ToTable("Mentor");

            builder.HasMany(c => c.MentorCourses)
                .WithOne(m => m.Mentor)
                .HasForeignKey(x => x.MentorId);

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(13)
                .IsRequired();
        }
    }
}
