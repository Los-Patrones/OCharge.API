using DefaultNamespace;

namespace WebApplication1.App.Domain.Core;

public interface IBrandVehicleService
{
    Task<IEnumerable<BrandVehicle>> ListAsync();
    Task<IEnumerable<BrandVehicle>> ListByCategoryIdAsync(int brandVehicleId);
    Task<IBrandVehicleRepository> SaveAsync(BrandVehicle brandVehicle);
    Task<IBrandVehicleRepository> UpdateAsync(int id, BrandVehicle brandVehicle);
    Task<IBrandVehicleRepository> DeleteAsync(int id);
}