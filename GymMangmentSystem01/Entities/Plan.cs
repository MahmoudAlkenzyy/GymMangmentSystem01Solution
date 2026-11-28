namespace GymMangmentSystem01.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; }
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = default!;
        public bool IsActive { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip> ( );
    }
}
