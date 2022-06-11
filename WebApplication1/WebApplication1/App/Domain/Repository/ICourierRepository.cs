using WebApplication1.App.Domain;

namespace WebApplication1.App.Domain.Repository;

public interface CourierRepository
{
    Task<IEnumerable<Courier>> ListAsync();
    Task AddAsync(Courier courier);
    Task<Courier> FindByIdAsync(int id);
    void Update(Courier courier);
    void Remove(Courier courier);
}