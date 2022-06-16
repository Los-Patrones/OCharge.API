using WebApplication1.app.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class PaymentServiceService:IPaymentServiceService
{
    public Task<IEnumerable<PaymentService>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PaymentService>> ListByCategoryIdAsync(int paymentServiceId)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServiceResponse> SaveAsync(PaymentService paymentService)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServiceResponse> UpdateAsync(int id, PaymentService paymentService)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentServiceResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}