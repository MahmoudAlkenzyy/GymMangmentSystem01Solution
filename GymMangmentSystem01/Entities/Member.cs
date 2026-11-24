namespace GymMangmentSystem01.Entities
{
    public class Member : GymUser
    {
        public DateOnly DateOfJoin { get; set; }
        public string? Photo { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip> ( );


    }
}
