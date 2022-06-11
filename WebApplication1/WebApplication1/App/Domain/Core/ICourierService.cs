using WebApplication1.App.Domain.Repository;

namespace WebApplication1.App.Domain.Core;


public interface ICourierService
{
    Task<IEnumerable<Courier>> ListAsync();
    Task<IEnumerable<Courier>> ListByCategoryIdAsync(int courierId);
    Task<CourierRepository> SaveAsync(Courier courier);
    Task<CourierRepository> UpdateAsync(int id, Courier courier);
    Task<CourierRepository> DeleteAsync(int id);
}