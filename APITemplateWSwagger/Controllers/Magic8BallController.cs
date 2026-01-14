using Microsoft.AspNetCore.Mvc;
using APITemplateWSwagger.Services;

namespace APITemplateWSwagger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly Magic8BallService service;

    public Magic8BallController(Magic8BallService service)
    {
        this.service = service;
    }

    [HttpGet("ask")]
    public IActionResult Ask()
    {
        return Ok(service.GetResponse());
    }
}
