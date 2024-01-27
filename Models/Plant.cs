namespace Plants_Api.Models
{
    public class Plant
    {
        public int Id { get; set; }
        //NickName is required, and will eventually be set to a random name on creation of new plant
        public required string NickName { get; set; }
        public int RoomId { get; set; }
        public int PlantDetailsId { get; set; }
        public required IEnumerable<Picture> Pictures { get; set; }
    }
}