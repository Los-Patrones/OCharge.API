

using WebApplication1.App.Shared.Persistence.Contexts;
using WebApplication1.Shared.Domain.Repositories;

namespace WebApplication1.App.Persistence.Repositories;

public class UnitOfWork:IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }


    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}