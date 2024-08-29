using AcademySystem.Data;
using AcademySystem.Models;
using MaterialDesignColors;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace AcademySystem.Services
{
    public class StudentsService
    {
        private readonly AcademySystemDbContext _context;

        public StudentsService()
        {
            _context = new AcademySystemDbContext();
        }

        public List<Student> GetStudents(string search = "")
        {
            var query = _context.Students
                .Include(x => x.Enrollments)
                .ThenInclude(a => a.Group)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.FirstName.Contains(search) ||
                    x.LastName.Contains(search) ||
                    x.PhoneNumber.Contains(search));
            }

            return query.ToList();
        }
    }
}
