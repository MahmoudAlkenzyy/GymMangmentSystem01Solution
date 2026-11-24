namespace GymMangmentSystem01.Entities
{
    public class Address : BaseEntity
    {
        public int BuildingNumber { get; set; }
        public string street { get; set; } = default!;
        public string City { get; set; } = default!;

    }
}
