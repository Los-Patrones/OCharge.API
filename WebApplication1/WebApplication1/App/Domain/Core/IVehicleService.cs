using WebApplication1.App.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core;

public interface IVehicleService
{
    Task<IEnumerable<Vehicle>> ListAsync();
    Task<IEnumerable<Vehicle>> ListByCategoryIdAsync(int vehicle);
    Task<VehicleResponse> SaveAsync(Vehicle vehicle);
    Task<VehicleResponse> UpdateAsync(int id, Vehicle vehicle);
    Task<VehicleResponse> DeleteAsync(int id);
}