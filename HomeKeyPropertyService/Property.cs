namespace HomeKeyPropertyService
{
    public class Property
    {
        public int Id { get; set; } 
        public string Address { get; set; }
        public List<string>? Images { get; set; }
        public List<string>? Videos { get; set; }
        public List<string>? Floorplans { get; set; }
        public DateTime DateAdded { get; set; }
        public int Bedrooms { get; set; }
        public int Bathroms { get; set; }
        public List
        public string? HouseType { get; set; }
        public string? Tenure { get; set; }
        public string? Description { get; set; }
        public string AgentId { get; set; }

    }
}
