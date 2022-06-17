using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IPersonService
{
    Task<IEnumerable<Person>> ListAsync();
    Task<PersonResponse> SaveAsync(Person person);
    Task<PersonResponse> UpdateAsync(int id, Person person);
    Task<PersonResponse> DeleteAsync(int id);
}