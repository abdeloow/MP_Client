using Microsoft.AspNetCore.Mvc;
using MultipleHtppClient.Infrastructure;

namespace MultipleHtppClient.API;

[ApiController]
[Route("api/[controller]")]
public class PresentationController : ControllerBase
{
    private readonly IUseHttpService _useHttpService;

    public PresentationController(IUseHttpService useHttpService)
    {
        _useHttpService = useHttpService;
    }

    [HttpGet("All")]
    public async Task<IActionResult> GetAll()
    {
        var response = await _useHttpService.GetAllProductsAsync();

        if (!response.IsSuccess)
        {
            return StatusCode((int)response.StatusCode, response.ErrorMessage);
        }

        return Ok(response.Data);
    }
}
