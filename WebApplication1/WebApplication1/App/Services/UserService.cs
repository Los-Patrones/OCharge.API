using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class UserService:IUserService
{
    public Task<IEnumerable<User>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> ListByCategoryIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> SaveAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> UpdateAsync(int id, User user)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}