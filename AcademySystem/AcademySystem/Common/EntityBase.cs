using System.ComponentModel.DataAnnotations;

namespace AcademySystem.Common
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
