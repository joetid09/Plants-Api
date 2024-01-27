namespace Plants_Api.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public required string Url { get; set; }
        public bool IsDefault { get; set; }
    }
}