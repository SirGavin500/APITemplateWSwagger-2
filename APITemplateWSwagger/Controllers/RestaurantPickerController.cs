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
        var result = service.Pick(category);

        if (result == "Invalid category")
        {
            return BadRequest(new
            {
                error = "Invalid category",
                availableCategories = service.GetCategories()
            });
        }

        return Ok(result);
    }
}
