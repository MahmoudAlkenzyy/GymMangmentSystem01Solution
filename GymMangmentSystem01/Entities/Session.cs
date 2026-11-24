namespace GymMangmentSystem01.Entities
{
    public class Session : BaseEntity
    {
        public int Capacity { get; set; }
        public string Description { get; set; } = default!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
