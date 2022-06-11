using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class ServiceResponse : BaseResponse<Service>
{
    public ServiceResponse(Service resource) : base(resource)
    {
    }

    public ServiceResponse(string message) : base(message)
    {
    }
}