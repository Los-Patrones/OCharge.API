using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class VehicleService:IVehicleService
{
    public Task<IEnumerable<Vehicle>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vehicle>> ListByCategoryIdAsync(int vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleResponse> SaveAsync(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleResponse> UpdateAsync(int id, Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<VehicleResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}