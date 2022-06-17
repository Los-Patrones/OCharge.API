using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Resources;
using WebApplication1.App.Shared.Extensions;

namespace WebApplication1.App.Controllers;

[Route("/api/v1/[controller]")]
public class PersonsController:ControllerBase
{
    private readonly IPersonService _PersonService;
    private readonly IMapper _mapper;


    public PersonsController(IPersonService PersonService, IMapper mapper)
    {
        _PersonService = PersonService;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IEnumerable<PersonResource>> GetAllAsync()
    {
        var person = await _PersonService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Person>, IEnumerable<PersonResource>>(person);

        return resources;
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("Person Information to Add", Required = true)] PersonResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var person = _mapper.Map<PersonResource, Person>(resource);

        var result = await _PersonService.SaveAsync(person);

        if (!result.Success)
            return BadRequest(result.Message);

        var personResource = _mapper.Map<Person, PersonResource>(result.Resource);

        return Ok(personResource);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SavePaymentMethodResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var person = _mapper.Map<SavePaymentMethodResource, Person>(resource);

        var result = await _PersonService.UpdateAsync(id, person);

        if (!result.Success)
            return BadRequest(result.Message);

        var personResource = _mapper.Map<Person, PersonResource>(result.Resource);

        return Ok(personResource);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _PersonService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var personResource = _mapper.Map<Person, PersonResource>(result.Resource);

        return Ok(personResource);
    }
}