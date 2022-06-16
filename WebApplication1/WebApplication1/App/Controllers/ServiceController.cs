﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Resources;

namespace WebApplication1.App.Controllers;

public class ServiceController:ControllerBase
{
    
    private readonly IServiceService _serviceService;
    private readonly IMapper _mapper;


    public ServiceController(IServiceService serviceService, IMapper mapper)
    {
        _serviceService = serviceService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ServiceResource>> GetAllAsync()
    {
        var service = await _serviceService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceResource>>(service);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("Service Information to Add", Required = true)] SaveServiceResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var service = _mapper.Map<SaveServiceResource, Service>(resource);

        var result = await _serviceService.SaveAsync(service);

        if (!result.Success)
            return BadRequest(result.Message);

        var serviceResource = _mapper.Map<Service, SaveServiceResource>(result.Resource);

        return Ok(serviceResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveServiceResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var service = _mapper.Map<SaveServiceResource, Service>(resource);

        var result = await _serviceService.UpdateAsync(id, service);

        if (!result.Success)
            return BadRequest(result.Message);

        var serviceResource = _mapper.Map<Service, SaveServiceResource>(result.Resource);

        return Ok(serviceResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _serviceService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var serviceResource = _mapper.Map<Service, SaveServiceResource>(result.Resource);

        return Ok(serviceResource);
    }
    
}