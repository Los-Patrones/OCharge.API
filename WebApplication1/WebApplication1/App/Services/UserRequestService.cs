using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class UserRequestService:IUserRequestService
{
    public Task<IEnumerable<UserRequest>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserRequest>> ListByCategoryIdAsync(int userRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserRequestResponse> SaveAsync(UserRequest userRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserRequestResponse> UpdateAsync(int id, UserRequest userRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserRequestResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}