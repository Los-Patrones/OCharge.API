using WebApplication1.App.Domain;

namespace DefaultNamespace;

public interface IBrandVehicleRepository
{
    Task<IEnumerable<BrandVehicle>> ListAsnc();
    Task AddAsync(BrandVehicle brandVehicle);
    Task<BrandVehicle> FindByIdAsync(int id);
    void Update(BrandVehicle brandVehicle);
    void Remove(BrandVehicle brandVehicle);
}