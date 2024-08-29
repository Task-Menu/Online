using AcademySystem.Common;
using AcademySystem.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademySystem.Models;

public class Gruop : AuditableEntity
{
    public string Name { get; set; }
    public StudyMode Mode { get; set; }
    public int MentorCourseId { get; set; }
    public virtual MentorCourse MentorCourses { get; set; }
    public virtual IEnumerable<Enrollment> Enrollments { get; set; }
}
