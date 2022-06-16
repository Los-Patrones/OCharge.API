using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class PaymentServiceResponse : BaseResponse<PaymentService>
{
    public PaymentServiceResponse(PaymentService resource) : base(resource)
    {
    }

    public PaymentServiceResponse(string message) : base(message)
    {
    }
}