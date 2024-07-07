using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Models
{
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string TotalHours { get; set; }

        public virtual CourseTeacher CourseTeacher {  get; set; }

        public Course()
        {
        }
        public Course(int id, string name, string description, decimal price, string totalHours)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            TotalHours = totalHours;
        }
    }
}
