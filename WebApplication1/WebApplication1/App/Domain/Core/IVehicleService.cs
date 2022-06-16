using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IVehicleService
{
    Task<IEnumerable<Vehicle>> ListAsync();
    Task<VehicleResponse> SaveAsync(Vehicle vehicle);
    Task<VehicleResponse> UpdateAsync(int id, Vehicle vehicle);
    Task<VehicleResponse> DeleteAsync(int id);
}