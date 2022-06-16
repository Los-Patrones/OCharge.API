using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class CourierService:ICourierService
{
    public Task<IEnumerable<Courier>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Courier>> ListByCategoryIdAsync(int courierId)
    {
        throw new NotImplementedException();
    }

    public Task<CourierResponse> SaveAsync(Courier courier)
    {
        throw new NotImplementedException();
    }

    public Task<CourierResponse> UpdateAsync(int id, Courier courier)
    {
        throw new NotImplementedException();
    }

    public Task<CourierResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}