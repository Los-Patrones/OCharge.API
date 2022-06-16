using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Persistence.Contexts;

namespace DefaultNamespace;

public class VehicleRepository:BaseRepository,IVehicleRepository
{
    public VehicleRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Vehicle>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<Vehicle> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public void Remove(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }
}