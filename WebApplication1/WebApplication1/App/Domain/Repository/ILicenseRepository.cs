

using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Repository;

public interface ILicenseRepository
{
    Task<IEnumerable<License>> ListAsync();
    Task AddAsync(License license);
    Task<License> FindByIdAsync(int id);
    void Update(License license);
    void Remove(License license);
}