using WebApplication1.App.Domain.Repository;

namespace WebApplication1.App.Domain.Core;


public interface ICourierService
{
    Task<IEnumerable<Courier>> ListAsync();
    Task<IEnumerable<Courier>> ListByCategoryIdAsync(int courierId);
    Task<ICourierRepository> SaveAsync(Courier courier);
    Task<ICourierRepository> UpdateAsync(int id, Courier courier);
    Task<ICourierRepository> DeleteAsync(int id);
}