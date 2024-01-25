namespace Plants_Api
{
    public class PlantDetails
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? photo { get; set; }
        public int availableUnits { get; set; }
        public bool wifi { get; set; }
        public bool laundry { get; set; }
    }
}
