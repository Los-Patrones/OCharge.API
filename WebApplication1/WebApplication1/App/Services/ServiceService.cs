using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class ServiceService:IServiceService
{
    public Task<IEnumerable<Service>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Service>> ListByCategoryIdAsync(int service)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> SaveAsync(Service service)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> UpdateAsync(int id, Service service)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}