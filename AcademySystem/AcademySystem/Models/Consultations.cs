using System;
using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Models
{
    public class Consultations
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }

        public Consultations(string firstname, string lastname, string phonenumber, DateTime birthday)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;
            Birthday = birthday;
        }
    }
}
