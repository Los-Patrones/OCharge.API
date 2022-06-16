using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IBrandVehicleService
{
    Task<IEnumerable<BrandVehicle>> ListAsync();
    Task<BrandVehicleResponse> SaveAsync(BrandVehicle brandVehicle);
    Task<BrandVehicleResponse> UpdateAsync(int id, BrandVehicle brandVehicle);
    Task<BrandVehicleResponse> DeleteAsync(int id);
}