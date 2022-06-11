using WebApplication1.App.Domain;

namespace WebApplication1.App.Domain.Repository;

public interface VehicleRepository
{
    Task<IEnumerable<Vehicle>> ListAsync();
    Task AddAsync(Vehicle vehicle);
    Task<Vehicle> FindByIdAsync(int id);
    void Update(Vehicle vehicle);
    void Remove(Vehicle vehicle);
}