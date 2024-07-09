using AcademySystem.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcademySystem.Data
{
    internal class AcademySystemDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseTeacher> CourseTeachers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<RequestOffer> RequestOffer { get; set; }
        public virtual DbSet<Consultations> Consultations { get; set; }


        public AcademySystemDbContext()
        {
            Database.SetCommandTimeout(TimeSpan.FromMinutes(5));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PAVILION;Initial Catalog=Academy;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
