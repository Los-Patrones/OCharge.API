using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;
public class VehicleRepository:BaseRepository,IVehicleRepository
{
    public VehicleRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Vehicle>> ListAsync()
    {
        return await _context.Vehicles.ToListAsync();
    }

    public async Task AddAsync(Vehicle vehicle)
    {
        await _context.Vehicles.AddAsync(vehicle);
    }

    public async Task<Vehicle> FindByIdAsync(int id)
    {
        return await _context.Vehicles.FindAsync(id);
    }

    public void Update(Vehicle vehicle)
    {
        _context.Vehicles.Update(vehicle);
    }

    public void Remove(Vehicle vehicle)
    {
        _context.Vehicles.Remove(vehicle);
    }
}