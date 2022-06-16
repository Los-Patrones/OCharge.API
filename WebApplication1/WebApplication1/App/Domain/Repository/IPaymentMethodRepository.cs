using WebApplication1.App.Domain.Models;

namespace WebApplication1.App.Domain.Repository;

public interface IPaymentMethodRepository
{
    Task<IEnumerable<PaymentMethod>> ListAsync();
    Task AddAsync(PaymentMethod paymentMethod);
    Task<PaymentMethod> FindByIdAsync(int id);
    void Update(PaymentMethod paymentMethod);
    void Remove(PaymentMethod paymentMethod);
}