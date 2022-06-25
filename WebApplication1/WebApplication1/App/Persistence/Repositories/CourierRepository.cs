using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;
public class CourierRepository:BaseRepository,ICourierRepository
{
    public CourierRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Courier>> ListAsync()
    {
        return await _context.Couriers.ToListAsync();
    }

    public async Task AddAsync(Courier courier)
    {
       await _context.Couriers.AddAsync(courier);
    }

    public async Task<Courier> FindByIdAsync(int id)
    {
        return await _context.Couriers.FindAsync(id);
    }

    public void Update(Courier courier)
    {
        _context.Couriers.Update(courier);
    }

    public void Remove(Courier courier)
    {
        _context.Couriers.Remove(courier);
    }
}