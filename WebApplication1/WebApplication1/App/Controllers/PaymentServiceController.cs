using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.app.Domain.Core;

namespace DefaultNamespace;

public class PaymentServiceController:ControllerBase
{
    
    private readonly IPaymentServiceService _paymentServiceService;
    private readonly IMapper _mapper;


    public PaymentServiceController(IPaymentServiceService paymentServiceService, IMapper mapper)
    {
        _paymentServiceService = paymentServiceService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<PaymentServiceResource>> GetAllAsync()
    {
        var paymentService = await _paymentServiceService.ListAsync();
        var resources = _mapper.Map<IEnumerable<PaymentService>, IEnumerable<PaymentServiceResource>>(paymentService);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("PaymentService Information to Add", Required = true)] PaymentServiceResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var paymentService = _mapper.Map<PaymentServiceResource, PaymentService>(resource);

        var result = await _paymentServiceService.SaveAsync(paymentService);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] PaymentServiceResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var paymentService = _mapper.Map<SavePaymentServiceResource, PaymentService>(resource);

        var result = await _paymentServiceService.UpdateAsync(id, paymentService);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _paymentServiceService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    
    
}