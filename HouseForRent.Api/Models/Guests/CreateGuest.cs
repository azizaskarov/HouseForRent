using HouseForRent.Api.Entities.Foundation.Guests;

namespace HouseForRent.Api.Models.Guests;

public class CreateGuest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTimeOffset BirthDate { get; set; }
    public GenderType Gender { get; set; }
}