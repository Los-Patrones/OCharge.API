using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;

namespace WebApplication1.App.Domain.Core;


public interface ICourierService
{
    Task<IEnumerable<Courier>> ListAsync();
    Task<IEnumerable<Courier>> ListByCategoryIdAsync(int courierId);
    Task<CourierResponse> SaveAsync(Courier courier);
    Task<CourierResponse> UpdateAsync(int id, Courier courier);
    Task<CourierResponse> DeleteAsync(int id);
}