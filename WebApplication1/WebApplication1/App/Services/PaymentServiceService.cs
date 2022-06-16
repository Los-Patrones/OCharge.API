using WebApplication1.app.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.Shared.Domain.Repositories;

namespace WebApplication1.App.Services;

public class PaymentServiceService:IPaymentServiceService
{
    private readonly IPaymentServiceRepository _paymentServiceRepository;

    private readonly IUnitOfWork _unitOfWork;
    public PaymentServiceService(IPaymentServiceRepository PaymentServiceRepository, IUnitOfWork unitOfWork)
    {
        _paymentServiceRepository = PaymentServiceRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<PaymentService>> ListAsync()
    {
        return await _paymentServiceRepository.ListAsync();
    }

    public async Task<PaymentServiceResponse> SaveAsync(PaymentService paymentService)
    {
        try
        {
            await _paymentServiceRepository.AddAsync(paymentService);
            await _unitOfWork.CompleteAsync();

            return new PaymentServiceResponse(paymentService);
        }
        catch (Exception e)
        {
            return new PaymentServiceResponse($"An error occurred while saving the PaymentService: {e.Message}");
        }
    }

    public async Task<PaymentServiceResponse> UpdateAsync(int id, PaymentService paymentService)
    {
        var existingPaymentService = await _paymentServiceRepository.FindByIdAsync(id);

        if (existingPaymentService == null)
            return new PaymentServiceResponse("PaymentService not found.");

        existingPaymentService.CardUser = paymentService.CardUser;
        existingPaymentService.CardCourier = paymentService.CardCourier;

        try
        {
            _paymentServiceRepository.Update(existingPaymentService);
            await _unitOfWork.CompleteAsync();
            
            return new PaymentServiceResponse(existingPaymentService);
        }
        catch (Exception e)
        {
            return new PaymentServiceResponse($"An error occurred while updating the PaymentService: {e.Message}");
        }
    }

    public async Task<PaymentServiceResponse> DeleteAsync(int id)
    {
        var existingPaymentService = await _paymentServiceRepository.FindByIdAsync(id);

        if (existingPaymentService == null)
            return new PaymentServiceResponse("PaymentService not found.");

        try
        {
            _paymentServiceRepository.Remove(existingPaymentService);
            await _unitOfWork.CompleteAsync();

            return new PaymentServiceResponse(existingPaymentService);
        }
        catch (Exception e)
        {
            // Do some logging stuff
            return new PaymentServiceResponse($"An error occurred while deleting the PaymentService: {e.Message}");
        }
    }
}