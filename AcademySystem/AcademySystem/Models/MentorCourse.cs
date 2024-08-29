using AcademySystem.Common;
using System.Collections.Generic;

namespace AcademySystem.Models;

public class MentorCourse : AuditableEntity
{
    public int MentorId { get; set; }
    public virtual Mentor Mentor { get; set; }
    public int CourseId { get; set; }
    public virtual Course Courses { get; set; }
    public virtual IEnumerable<Gruop> Groups { get; set; }
}
