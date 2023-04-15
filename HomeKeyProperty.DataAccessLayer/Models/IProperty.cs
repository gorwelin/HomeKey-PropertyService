using HomeKeyProperty.DataAccessLayer.Models;

namespace HomeKeyPropertyService
{
    public interface IProperty
    {
        int Id { get; set; } 
        string Name { get; set; }
        string Address { get; set; }
        List<string>? Images { get; set; }
        List<string>? Videos { get; set; }
        List<string>? Floorplans { get; set; }
        DateTime DateAdded { get; set; }
        int Bedrooms { get; set; }
        int Bathroms { get; set; }
        List<Room> Rooms { get; set; }
        string? HouseType { get; set; }
        string? Tenure { get; set; }
        string? Description { get; set; }
        int? AgentId { get; set; }
        int? EnergyRatingId { get; set; }

    }
}
