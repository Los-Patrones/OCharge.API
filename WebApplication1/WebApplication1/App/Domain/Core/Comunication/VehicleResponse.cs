using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class VehicleResponse : BaseResponse<Vehicle>
{
    public VehicleResponse(Vehicle resource) : base(resource)
    {
    }

    public VehicleResponse(string message) : base(message)
    {
    }
}