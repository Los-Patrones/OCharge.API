using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Services;

public class PaymentMethodService:IPaymentMethodService
{
    public Task<IEnumerable<PaymentMethod>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PaymentMethod>> ListByCategoryIdAsync(int paymentMethodId)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodResponse> SaveAsync(PaymentMethod paymentMethod)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodResponse> UpdateAsync(int id, PaymentMethod paymentMethod)
    {
        throw new NotImplementedException();
    }

    public Task<PaymentMethodResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}