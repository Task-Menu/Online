using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Models
{
    internal class RequestOffer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageText { get; set; }

        public RequestOffer(string firstName, string lastName, string messageText)
        {
            FirstName = firstName;
            LastName = lastName;
            MessageText = messageText;
        }
    }
}
