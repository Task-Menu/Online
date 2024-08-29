using AcademySystem.Common;

namespace AcademySystem.Models
{
    public class Enrollment : EntityBase
    {
        public int GroupId {  get; set; }
        public virtual Gruop Group { get; set; }
        public int StudentId {  get; set; }
        public virtual Student Student { get; set; }
    }
}
