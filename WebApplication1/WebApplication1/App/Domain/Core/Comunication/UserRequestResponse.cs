using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class UserRequestResponse : BaseResponse<UserRequest>
{
    public UserRequestResponse(UserRequest resource) : base(resource)
    {
    }

    public UserRequestResponse(string message) : base(message)
    {
    }
}