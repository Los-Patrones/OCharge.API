using Microsoft.AspNetCore.Mvc;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Core.Comunication;
using WebApplication1.App.Resources;

namespace DefaultNamespace;

public class LicenseCategoryController:ControllerBase
{
    private readonly ILicenseCategoryService _licenseCategoryService;
    private readonly IMapper _mapper;
    
    public LicenseCategoryController(ILicenseCategoryService licenseCategoryService, IMapper mapper)
    {
        _licenseCategoryService = licenseCategoryService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<LicenseCategoryResource>> GetAllAsync()
    {
        var licenseCategory = await _licenseCategoryService.ListAsync();
        var resources = _mapper.Map<IEnumerable<LicenseCategory>, IEnumerable<LicenseCategoryResource>>(licenseCategory);

        return resources;
    }
    
    public async Task<IActionResult> PostAsync([FromBody, SwaggerRequestBody("LicenseCategory Information to Add", Required = true)] SaveLicenseCategoryResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var licenseCategory = _mapper.Map<SaveLicenseCategoryResource, LicenseCategory>(resource);

        var result = await _licenseCategoryService.SaveAsync(licenseCategory);

        if (!result.Success)
            return BadRequest(result.Message);

        var licenseCategoryResource = _mapper.Map<LicenseCategory, LicenseCategoryResource>(result.Resource);

        return Ok(licenseCategoryResource);
    }
    
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveLicenseCategoryResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var licenseCategory = _mapper.Map<SaveLicenseCategoryResource, LicenseCategory>(resource);

        var result = await _licenseCategoryService.UpdateAsync(id, licenseCategory);

        if (!result.Success)
            return BadRequest(result.Message);

        var licenseCategoryResource = _mapper.Map<LicenseCategory, LicenseCategoryResource>(result.Resource);

        return Ok(licenseCategoryResource);
    }
    
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _licenseCategoryService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var licenseCategoryResource = _mapper.Map<LicenseCategory, LicenseCategoryResource>(result.Resource);

        return Ok(licenseCategoryResource);
    }
}