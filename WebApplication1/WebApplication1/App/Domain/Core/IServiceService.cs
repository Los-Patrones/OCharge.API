using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IServiceService
{
    Task<IEnumerable<Service>> ListAsync();
    Task<ServiceResponse> SaveAsync(Service service);
    Task<ServiceResponse> UpdateAsync(int id, Service service);
    Task<ServiceResponse> DeleteAsync(int id);
}