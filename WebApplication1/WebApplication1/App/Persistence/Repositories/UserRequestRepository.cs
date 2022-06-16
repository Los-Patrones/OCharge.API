using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Persistence.Contexts;

namespace DefaultNamespace;

public class UserRequestRepository : BaseRepository,IUserRequestRepository
{
    public UserRequestRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<UserRequest>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(UserRequest userRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserRequest> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(UserRequest userRequest)
    {
        throw new NotImplementedException();
    }

    public void Remove(UserRequest userRequest)
    {
        throw new NotImplementedException();
    }
}