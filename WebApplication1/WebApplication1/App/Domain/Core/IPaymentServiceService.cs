using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core.Comunication;

namespace WebApplication1.app.Domain.Core;


public interface IPaymentServiceService
{
    Task<IEnumerable<PaymentService>> ListAsync();
    Task<IEnumerable<PaymentService>> ListByCategoryIdAsync(int paymentServiceId);
    Task<PaymentServiceResponse> SaveAsync(PaymentService paymentService);
    Task<PaymentServiceResponse> UpdateAsync(int id, PaymentService paymentService);
    Task<PaymentServiceResponse> DeleteAsync(int id);
}