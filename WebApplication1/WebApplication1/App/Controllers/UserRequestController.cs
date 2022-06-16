using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Resources;

namespace DefaultNamespace;

public class UserRequestController:ControllerBase
{
    
    private readonly IUserRequestService _userRequestService;
    private readonly IMapper _mapper;


    public UserRequestController(IUserRequestService userRequestService, IMapper mapper)
    {
        _userRequestService = userRequestService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<UserRequestResource>> GetAllAsync()
    {
        var userRequest = await _userRequestService.ListAsync();
        var resources = _mapper.Map<IEnumerable<UserRequest>, IEnumerable<UserRequestResource>>(userRequest);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("UserRequest Information to Add", Required = true)] SaveUserRequestResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var userRequest = _mapper.Map<SaveUserRequestResource, UserRequest>(resource);

        var result = await _userRequestService.SaveAsync(userRequest);

        if (!result.Success)
            return BadRequest(result.Message);

        var userRequestResource = _mapper.Map<UserRequest, UserRequestResource>(result.Resource);

        return Ok(userRequestResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveUserRequestResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var userRequest = _mapper.Map<SaveUserRequestResource, UserRequest>(resource);

        var result = await _userRequestService.UpdateAsync(id, userRequest);

        if (!result.Success)
            return BadRequest(result.Message);

        var userRequestResource = _mapper.Map<UserRequest, SaveUserRequestResource>(result.Resource);

        return Ok(userRequestResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _userRequestService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var userRequestResource = _mapper.Map<UserRequest, SaveUserRequestResource>(result.Resource);

        return Ok(userRequestResource);
    }
}