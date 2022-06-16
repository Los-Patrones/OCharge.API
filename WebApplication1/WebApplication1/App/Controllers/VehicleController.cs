using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Resources;

namespace WebApplication1.App.Controllers;

public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;
    private readonly IMapper _mapper;


    public VehicleController(IVehicleService vehicleService, IMapper mapper)
    {
        _vehicleService = vehicleService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<VehicleResource>> GetAllAsync()
    {
        var vehicle = await _vehicleService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Vehicle>, IEnumerable<VehicleResource>>(vehicle);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("Vehicle Information to Add", Required = true)] SaveVehicleResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var vehicle = _mapper.Map<SaveVehicleResource, Vehicle>(resource);

        var result = await _vehicleService.SaveAsync(vehicle);

        if (!result.Success)
            return BadRequest(result.Message);

        var vehicleResource = _mapper.Map<Vehicle, VehicleResource>(result.Resource);

        return Ok(vehicleResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveVehicleResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var vehicle = _mapper.Map<SaveVehicleResource, Vehicle>(resource);

        var result = await _vehicleService.UpdateAsync(id, vehicle);

        if (!result.Success)
            return BadRequest(result.Message);

        var vehicleResource = _mapper.Map<Vehicle, VehicleResource>(result.Resource);

        return Ok(vehicleResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _vehicleService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var vehicleResource = _mapper.Map<Vehicle, VehicleResource>(result.Resource);

        return Ok(vehicleResource);
    }
    
    
}