using AcademySystem.Common.Constants;
using AcademySystem.Extensions;
using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcademySystem.Data
{
    public class AcademySystemDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Mentor> Mentors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<MentorCourse> MentorCourses { get; set; }
        public virtual DbSet<Gruop> Groups { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }


        public AcademySystemDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(new AuditInterceptor());
            optionsBuilder.UseSqlServer(ConnectionString.CONNECTION_STRING);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
