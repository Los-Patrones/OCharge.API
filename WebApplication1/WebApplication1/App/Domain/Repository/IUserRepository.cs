
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Repository;

public interface IUserRepository
{
    Task<IEnumerable<User>> ListAsync();
    Task AddAsync(User userService);
    Task<User> FindByIdAsync(int id);
    void Update(User userService);
    void Remove(User userService);
}