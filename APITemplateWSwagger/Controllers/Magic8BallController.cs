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
    public IActionResult Ask(string question)
    {
        // Validation: user must ask a question
        if (string.IsNullOrWhiteSpace(question))
        {
            return BadRequest("You must ask a question.");
        }

        return Ok(new
        {
            question = question,
            answer = service.GetResponse()
        });
    }
}
