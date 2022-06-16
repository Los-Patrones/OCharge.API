using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class PaymentMethodResponse:BaseResponse<PaymentMethod>
{
    public PaymentMethodResponse(PaymentMethod resource) : base(resource)
    {
    }

    public PaymentMethodResponse(string message) : base(message)
    {
    }
}