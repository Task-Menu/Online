using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademySystem.Models
{
    internal class CourseTeacher
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(TeacherId))]
        public virtual Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public virtual Group Group { get; set; }


        public CourseTeacher()
        {
            
        }
        public CourseTeacher(int id, int teacherId, int courseId, DateTime createdAt)
        {
            Id = id;
            TeacherId = teacherId;
            CourseId = courseId;
            CreatedAt = createdAt;
        }
    }
}
