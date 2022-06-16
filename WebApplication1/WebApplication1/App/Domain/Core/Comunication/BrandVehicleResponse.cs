using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class BrandVehicleResponse:BaseResponse<BrandVehicle>
{
    public BrandVehicleResponse(BrandVehicle resource) : base(resource)
    {
    }

    public BrandVehicleResponse(string message) : base(message)
    {
    }
}