using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.Shared.Domain.Repositories;

namespace WebApplication1.App.Services;

public class ServiceService:IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    private readonly IUnitOfWork _unitOfWork;
    public ServiceService(IServiceRepository serviceRepository, IUnitOfWork unitOfWork)
    {
        _serviceRepository = serviceRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<Service>> ListAsync()
    {
        return await _serviceRepository.ListAsync();
    }

    public async Task<ServiceResponse> SaveAsync(Service service)
    {
        try
        {
            await _serviceRepository.AddAsync(service);
            await _unitOfWork.CompleteAsync();

            return new ServiceResponse(service);
        }
        catch (Exception e)
        {
            return new ServiceResponse($"An error occurred while saving the Service: {e.Message}");
        }
    }

    public async Task<ServiceResponse> UpdateAsync(int id, Service service)
    {
        var existingService = await _serviceRepository.FindByIdAsync(id);

        if (existingService == null)
            return new ServiceResponse("Service not found.");

        existingService.IsFinalized = service.IsFinalized;

        try
        {
            _serviceRepository.Update(existingService);
            await _unitOfWork.CompleteAsync();
            
            return new ServiceResponse(existingService);
        }
        catch (Exception e)
        {
            return new ServiceResponse($"An error occurred while updating the Service: {e.Message}");
        }
    }

    public async Task<ServiceResponse> DeleteAsync(int id)
    {
        var existingService = await _serviceRepository.FindByIdAsync(id);

        if (existingService == null)
            return new ServiceResponse("Service not found.");

        try
        {
            _serviceRepository.Remove(existingService);
            await _unitOfWork.CompleteAsync();

            return new ServiceResponse(existingService);
        }
        catch (Exception e)
        {
            // Do some logging stuff
            return new ServiceResponse($"An error occurred while deleting the Service: {e.Message}");
        }
    }
}