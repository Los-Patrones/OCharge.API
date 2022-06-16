using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;

public class PaymentMethodRepository:BaseRepository,IPaymentServiceRepository
{
    public PaymentMethodRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<PaymentService>> ListAsync()
    {
        return await _context.PaymentServices.ToListAsync();
    }
 
    public async Task AddAsync(PaymentService paymentService)
    {
        await _context.PaymentServices.AddAsync(paymentService);
    }

    public async Task<PaymentService> FindByIdAsync(int id)
    {
        return await _context.PaymentServices.FindAsync(id);
    }

    public void Update(PaymentService paymentService)
    {
        _context.PaymentServices.Update(paymentService);
    }

    public void Remove(PaymentService paymentService)
    {
        _context.PaymentServices.Remove(paymentService);
    }
}