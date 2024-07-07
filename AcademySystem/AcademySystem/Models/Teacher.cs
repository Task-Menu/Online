using System;
using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Models
{
    internal class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual CourseTeacher CourseTeacher { get; set; }

        public Teacher()
        {
        }
        public Teacher(int id, string firstName, string lastName, DateTime createdAt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = createdAt;
        }
    }
}
