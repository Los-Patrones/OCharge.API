using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Core;

public interface IPaymentMethodService
{
    Task<IEnumerable<PaymentMethod>> ListAsync();
    Task<PaymentMethodResponse> SaveAsync(PaymentMethod paymentMethod);
    Task<PaymentMethodResponse> UpdateAsync(int id, PaymentMethod paymentMethod);
    Task<PaymentMethodResponse> DeleteAsync(int id);
}