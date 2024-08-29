using System.ComponentModel.DataAnnotations;
using System;
using AcademySystem.Common;
using System.Collections.Generic;

namespace AcademySystem.Models;

public class Student : AuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public virtual IEnumerable<Enrollment> Enrollments { get; set; }
}
