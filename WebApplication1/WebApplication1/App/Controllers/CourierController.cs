using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core;
using WebApplication1.App.Resources;

namespace DefaultNamespace;

public class CourierController: ControllerBase
{
    private readonly ICourierService _tutorialService;
    private readonly IMapper _mapper;

    public CourierController(ICourierService tutorialService, IMapper mapper)
    {
        _tutorialService = tutorialService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<CourierResource>> GetAllAsync()
    {
        var courier = await _courierService.ListAsync();

        var resources = _mapper.Map<IEnumerable<Courier>, IEnumerable<CourierResource>>(courier);

        return resources;
    }
}