using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class UserResponse:BaseResponse<User>
{
    public UserResponse(User resource) : base(resource)
    {
    }

    public UserResponse(string message) : base(message)
    {
    }
}