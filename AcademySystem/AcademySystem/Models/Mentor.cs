using AcademySystem.Common;
using AcademySystem.Enums;
using System.Collections.Generic;

namespace AcademySystem.Models;

public class Mentor : AuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public Degree Degree { get; set; }
    public virtual IEnumerable<MentorCourse> MentorCourses { get; set; }
}
