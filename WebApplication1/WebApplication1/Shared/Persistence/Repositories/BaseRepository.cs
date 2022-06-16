



using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;
    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}