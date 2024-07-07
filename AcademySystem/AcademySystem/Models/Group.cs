using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademySystem.Models
{
    internal class Group
    {
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }

        [ForeignKey(nameof(CourseTeacherId))]
        public virtual CourseTeacher CourseTeacher { get; set; }
        public int CourseTeacherId { get; set; }

        public Group()
        {
        }
        public Group(int id, string groupName, int courseTeacherId)
        {
            Id = id;
            GroupName = groupName;
            CourseTeacherId = courseTeacherId;
        }
    }
}
