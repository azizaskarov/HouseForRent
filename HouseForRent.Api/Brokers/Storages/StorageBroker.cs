using EFxceptions;
using HouseForRent.Api.Entities.Foundation.Guests;
using Microsoft.EntityFrameworkCore;

namespace HouseForRent.Api.Brokers.Storages;

public partial class StorageBroker : EFxceptionsContext
{
    public DbSet<Guest> Guests => Set<Guest>();
    public StorageBroker(DbContextOptions<StorageBroker> options): base(options)
    {
    }


}