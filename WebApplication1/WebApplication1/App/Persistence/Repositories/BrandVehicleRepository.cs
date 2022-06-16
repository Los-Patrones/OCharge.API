using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;
public class BrandVehicleRepository: BaseRepository,IBrandVehicleRepository
{
    public BrandVehicleRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<BrandVehicle>> ListAsync()
    {
        return await _context.BrandVehicles.ToListAsync();
    }

    public async Task AddAsync(BrandVehicle brandVehicle)
    {
        await _context.BrandVehicles.AddAsync(brandVehicle);
    }

    public async Task<BrandVehicle> FindByIdAsync(int id)
    {
        return await _context.BrandVehicles.FindAsync(id);
    }

    public void Update(BrandVehicle brandVehicle)
    {
        _context.BrandVehicles.Update(brandVehicle);
    }

    public void Remove(BrandVehicle brandVehicle)
    {
        _context.BrandVehicles.Remove(brandVehicle);
    }
}
