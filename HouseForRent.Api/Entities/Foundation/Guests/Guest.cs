namespace HouseForRent.Api.Entities.Foundation.Guests;

public class Guest
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTimeOffset BirthDate { get; set; }
    public GenderType Gender { get; set; } 
}