using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Persistence.Contexts;

namespace DefaultNamespace;

public class CourierRepository:BaseRepository,ICourierRepository
{
    public CourierRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Courier>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Courier courier)
    {
        throw new NotImplementedException();
    }

    public Task<Courier> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Courier courier)
    {
        throw new NotImplementedException();
    }

    public void Remove(Courier courier)
    {
        throw new NotImplementedException();
    }
}