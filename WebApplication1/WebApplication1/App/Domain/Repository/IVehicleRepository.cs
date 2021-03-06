

using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Repository;

public interface IVehicleRepository
{
    Task<IEnumerable<Vehicle>> ListAsync();
    Task AddAsync(Vehicle vehicle);
    Task<Vehicle> FindByIdAsync(int id);
    void Update(Vehicle vehicle);
    void Remove(Vehicle vehicle);
}