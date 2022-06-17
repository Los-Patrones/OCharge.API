using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Repository;

public interface IPersonRepository
{
    Task<IEnumerable<Person>> ListAsync();
    Task AddAsync(Person person);
    Task<Person> FindByIdAsync(int id);
    void Update(Person Person);
    void Remove(Person Person);
}