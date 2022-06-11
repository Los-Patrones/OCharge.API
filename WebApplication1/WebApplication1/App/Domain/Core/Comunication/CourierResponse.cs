using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class CourierResponse: BaseResponse<Courier>
{
    public CourierResponse(Courier resource) : base(resource)
    {
    }

    public CourierResponse(string message) : base(message)
    {
    }
}