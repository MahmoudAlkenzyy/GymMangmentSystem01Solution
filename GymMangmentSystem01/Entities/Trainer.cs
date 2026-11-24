using GymMangmentSystem01.Entities.Enums;

namespace GymMangmentSystem01.Entities
{
    public class Trainer : GymUser
    {
        public DateOnly HireDate { get; set; }
        public Specialist Specialist { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session> ( );
    }
}
