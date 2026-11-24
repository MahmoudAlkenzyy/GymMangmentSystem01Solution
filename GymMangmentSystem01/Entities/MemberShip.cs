namespace GymMangmentSystem01.Entities
{
    public class MemberShip : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public string Status => StartDate > DateTime.Now ? "Up Coming" : EndDate < DateTime.Now ? "Expired" : "Active";

    }
}
