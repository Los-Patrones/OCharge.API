
using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class LicenseResponse:BaseResponse<License>
{
    public LicenseResponse(License resource) : base(resource)
    {
    }

    public LicenseResponse(string message) : base(message)
    {
    }
}