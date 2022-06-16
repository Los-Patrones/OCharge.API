using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;

namespace WebApplication1.app.Domain.Core;


public interface IPaymentServiceService
{
    Task<IEnumerable<PaymentService>> ListAsync();
    Task<PaymentServiceResponse> SaveAsync(PaymentService paymentService);
    Task<PaymentServiceResponse> UpdateAsync(int id, PaymentService paymentService);
    Task<PaymentServiceResponse> DeleteAsync(int id);
}