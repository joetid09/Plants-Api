namespace Plants_Api.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public int UserId { get; set; }
        public ICollection<Plant> Plants { get; set; } = null!;

    }
}