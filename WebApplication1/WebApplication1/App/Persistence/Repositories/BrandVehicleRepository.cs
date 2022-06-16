using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain;
using WebApplication1.App.Persistence.Contexts;


namespace DefaultNamespace;

public class BrandVehicleRepository: BaseRepository,IBrandVehicleRepository
{
    public BrandVehicleRepository(AppDbContext context) : base(context)
    {
        
    }

    public Task<IEnumerable<BrandVehicle>> ListAsnc()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(BrandVehicle brandVehicle)
    {
        throw new NotImplementedException();
    }

    public Task<BrandVehicle> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(BrandVehicle brandVehicle)
    {
        throw new NotImplementedException();
    }

    public void Remove(BrandVehicle brandVehicle)
    {
        throw new NotImplementedException();
    }
}
