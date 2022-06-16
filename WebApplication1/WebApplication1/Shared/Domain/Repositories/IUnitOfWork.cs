namespace WebApplication1.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}