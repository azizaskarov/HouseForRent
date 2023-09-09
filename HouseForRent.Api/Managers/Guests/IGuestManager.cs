using HouseForRent.Api.Entities.Foundation.Guests;
using HouseForRent.Api.Models.Guests;

namespace HouseForRent.Api.Managers.Guests;

public interface IGuestManager
{
    ValueTask<Guest> CreateGuestAsync(CreateGuest createGuest);
}