using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IUserRequestService
{
    Task<IEnumerable<UserRequest>> ListAsync();
    Task<IEnumerable<UserRequest>> ListByCategoryIdAsync(int userRequest);
    Task<UserRequestResponse> SaveAsync(UserRequest userRequest);
    Task<UserRequestResponse> UpdateAsync(int id, UserRequest userRequest);
    Task<UserRequestResponse> DeleteAsync(int id);
}