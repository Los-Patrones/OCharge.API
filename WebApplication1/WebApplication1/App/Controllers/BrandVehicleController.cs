using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Resources;


namespace WebApplication1.App.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces("application/json")]
[SwaggerTag("Create, read, update and delete Categories")]

public class BrandVehicleController:ControllerBase
{
    private readonly IBrandVehicleService _brandVehicleService;
    private readonly IMapper _mapper;
    
    public BrandVehicleController(IBrandVehicleService brandVehicleService, IMapper mapper)
    {
        _brandVehicleService = brandVehicleService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<BrandVehicleResource>> GetAllAsync()
    {
        var brandVehicle = await _brandVehicleService.ListAsync();
        var resources = _mapper.Map<IEnumerable<BrandVehicle>, IEnumerable<BrandVehicleResource>>(brandVehicle);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("BrandVehicle Information to Add", Required = true)] SaveBrandVehicleResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var brandVehicle = _mapper.Map<SaveBrandVehicleResource, BrandVehicle>(resource);

        var result = await _brandVehicleService.SaveAsync(brandVehicle);

        if (!result.Success)
            return BadRequest(result.Message);

        var brandVehicleResource = _mapper.Map<BrandVehicle, BrandVehicleResource>(result.Resource);

        return Ok(brandVehicleResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveBrandVehicleResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var brandVehicle = _mapper.Map<SaveBrandVehicleResource, BrandVehicle>(resource);

        var result = await _brandVehicleService.UpdateAsync(id, brandVehicle);

        if (!result.Success)
            return BadRequest(result.Message);

        var brandVehicleResource = _mapper.Map<BrandVehicle, BrandVehicleResource>(result.Resource);

        return Ok(brandVehicleResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _brandVehicleService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var brandVehicleResource = _mapper.Map<BrandVehicle, BrandVehicleResource>(result.Resource);

        return Ok(brandVehicleResource);
    }
    
    
}