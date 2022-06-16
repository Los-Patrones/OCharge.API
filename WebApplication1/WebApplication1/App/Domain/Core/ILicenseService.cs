using System.ComponentModel;
using WebApplication1.App.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core;

public interface ILicenseService
{
    Task<IEnumerable<License>> ListAsync();
    Task<LicenseResponse> SaveAsync(License license);
    Task<LicenseResponse> UpdateAsync(int id, License license);
    Task<LicenseResponse> DeleteAsync(int id);
}