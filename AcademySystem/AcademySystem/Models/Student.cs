using System.ComponentModel.DataAnnotations;
using System;

namespace AcademySystem.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        public string GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        public Student()
        {
        }
        public Student(int id, string groupId, string firstName, string lastName, int telNumber, DateTime createdAt)
        {
            Id = id;
            GroupId = groupId;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
            CreatedAt = createdAt;            
        }
    }
}
