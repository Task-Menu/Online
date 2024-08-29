using AcademySystem.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Models;

public class Course : AuditableEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int NumberOfModules { get; set; }
    public decimal Rating { get; set; }
    public virtual IEnumerable<MentorCourse> MentorCourses { get; set; }
}
