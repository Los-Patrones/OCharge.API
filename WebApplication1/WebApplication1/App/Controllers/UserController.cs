using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Resources;

namespace DefaultNamespace;

public class UserController:ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;


    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<UserResource>> GetAllAsync()
    {
        var user = await _userService.ListAsync();
        var resources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(user);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("User Information to Add", Required = true)] UserResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var user = _mapper.Map<UserResource, User>(resource);

        var result = await _userService.SaveAsync(user);

        if (!result.Success)
            return BadRequest(result.Message);

        var userResource = _mapper.Map<User, UserResource>(result.Resource);

        return Ok(userResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] UserResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var user = _mapper.Map<UserResource, User>(resource);

        var result = await _userService.UpdateAsync(id, user);

        if (!result.Success)
            return BadRequest(result.Message);

        var userResource = _mapper.Map<User, UserResource>(result.Resource);

        return Ok(userResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _userService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var userResource = _mapper.Map<User, UserResource>(result.Resource);

        return Ok(userResource);
    }
    
    
}