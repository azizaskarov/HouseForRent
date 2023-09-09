using HouseForRent.Api.Context;
using HouseForRent.Api.Entities.Foundation.Guests;
using HouseForRent.Api.Models.Guests;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HouseForRent.Api.Managers.Guests;

public class GuestManager : IGuestManager
{
    private readonly AppDbContext dbContext;

    public GuestManager(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async ValueTask<Guest> CreateGuestAsync(CreateGuest createGuest)
    {
        var guest = new Guest()
        {
            FirstName = createGuest.FirstName,
            LastName = createGuest.LastName,
            PhoneNumber = createGuest.PhoneNumber,
            Address = createGuest.Address,
            BirthDate = createGuest.BirthDate,
            Email = createGuest.Email,
            Gender = createGuest.Gender,
        };
        
        EntityEntry<Guest> entityGuest = await dbContext.Guests.AddAsync(guest);
        await dbContext.SaveChangesAsync();
        return entityGuest.Entity;
    }
}