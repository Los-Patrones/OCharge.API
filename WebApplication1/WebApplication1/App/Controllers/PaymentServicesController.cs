using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebApplication1.App.Domain;
using WebApplication1.app.Domain.Core;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Resources;
using WebApplication1.App.Shared.Extensions;

namespace WebApplication1.App.Controllers;

[Route("/api/v1/[controller]")]
public class PaymentServiceController:ControllerBase
{
    
    private readonly IPaymentServiceService _paymentServiceService;
    private readonly IMapper _mapper;


    public PaymentServiceController(IPaymentServiceService paymentServiceService, IMapper mapper)
    {
        _paymentServiceService = paymentServiceService;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IEnumerable<PaymentServiceResource>> GetAllAsync()
    {
        var paymentService = await _paymentServiceService.ListAsync();
        var resources = _mapper.Map<IEnumerable<PaymentService>, IEnumerable<PaymentServiceResource>>(paymentService);

        return resources;
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("PaymentService Information to Add", Required = true)] SavePaymentServiceResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var paymentService = _mapper.Map<SavePaymentServiceResource, PaymentService>(resource);

        var result = await _paymentServiceService.SaveAsync(paymentService);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SavePaymentMethodResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var paymentService = _mapper.Map<SavePaymentMethodResource, PaymentService>(resource);

        var result = await _paymentServiceService.UpdateAsync(id, paymentService);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _paymentServiceService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var paymentServiceResource = _mapper.Map<PaymentService, PaymentServiceResource>(result.Resource);

        return Ok(paymentServiceResource);
    }
    
}