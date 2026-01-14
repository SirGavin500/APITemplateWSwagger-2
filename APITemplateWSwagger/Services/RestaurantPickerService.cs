using Microsoft.AspNetCore.Mvc;
using APITemplateWSwagger.Services;

namespace APITemplateWSwagger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly RestaurantPickerService service;

    public RestaurantPickerController(RestaurantPickerService service)
    {
        this.service = service;
    }

    [HttpGet("{category}")]
    public IActionResult Pick(string category)
    {
        return Ok(service.Pick(category));
    }
}
