using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core.Comunication;

public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<IEnumerable<User>> ListByCategoryIdAsync(int userId);
    Task<UserResponse> SaveAsync(User user);
    Task<UserResponse> UpdateAsync(int id, User user);
    Task<UserResponse> DeleteAsync(int id);
}