using HouseForRent.Api.Entities.Foundation.Guests;
using Microsoft.EntityFrameworkCore;

namespace HouseForRent.Api.Context;

public partial class AppDbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>(guest =>
        {
            guest.HasData(new Guest()
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St",
                BirthDate = new DateTimeOffset(1990, 1, 1, 0, 0, 0, TimeSpan.Zero),
                Gender = GenderType.Male
            });
        });
    }
}