using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class BrandVehicleService:IBrandVehicleService
{
    public Task<IEnumerable<BrandVehicle>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BrandVehicle>> ListByCategoryIdAsync(int brandVehicleId)
    {
        throw new NotImplementedException();
    }

    public Task<BrandVehicleResponse> SaveAsync(BrandVehicle brandVehicle)
    {
        throw new NotImplementedException();
    }

    public Task<BrandVehicleResponse> UpdateAsync(int id, BrandVehicle brandVehicle)
    {
        throw new NotImplementedException();
    }

    public Task<BrandVehicleResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}