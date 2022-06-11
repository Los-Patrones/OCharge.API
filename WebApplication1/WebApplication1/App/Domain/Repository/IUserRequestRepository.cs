using WebApplication1.App.Domain;

namespace WebApplication1.App.Domain.Repository;

public interface UserRequestRepository
{
    Task<IEnumerable<UserRequest>> ListAsync();
    Task AddAsync(UserRequest userRequest);
    Task<UserRequest> FindByIdAsync(int id);
    void Update(UserRequest userRequest);
    void Remove(UserRequest userRequest);
}