using WebApplication1.App.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core;

public interface IServiceService
{
    Task<IEnumerable<Service>> ListAsync();
    Task<IEnumerable<Service>> ListByCategoryIdAsync(int service);
    Task<ServiceResponse> SaveAsync(Service service);
    Task<ServiceResponse> UpdateAsync(int id, Service service);
    Task<ServiceResponse> DeleteAsync(int id);
}