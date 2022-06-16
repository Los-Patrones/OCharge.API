using WebApplication1.App.Persistence.Contexts;

namespace DefaultNamespace;

public class BaseRepository
{
    protected readonly AppDbContext _context;
    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}