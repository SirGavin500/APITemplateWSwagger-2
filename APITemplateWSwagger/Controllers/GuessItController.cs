using Microsoft.AspNetCore.Mvc;
using APITemplateWSwagger.Services;

namespace APITemplateWSwagger.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuessItController : ControllerBase
{
    private readonly GuessItService service;

    public GuessItController(GuessItService service)
    {
        this.service = service;
    }

    [HttpGet("easy/{guess}")]
    public IActionResult Easy(int guess)
    {
        if (guess < 1 || guess > 10)
            return BadRequest("Guess must be between 1 and 10");

        int number = service.GenerateNumber(10);
        return Ok(service.Compare(guess, number));
    }

    [HttpGet("medium/{guess}")]
    public IActionResult Medium(int guess)
    {
        if (guess < 1 || guess > 50)
            return BadRequest("Guess must be between 1 and 50");

        int number = service.GenerateNumber(50);
        return Ok(service.Compare(guess, number));
    }

    [HttpGet("hard/{guess}")]
    public IActionResult Hard(int guess)
    {
        if (guess < 1 || guess > 100)
            return BadRequest("Guess must be between 1 and 100");

        int number = service.GenerateNumber(100);
        return Ok(service.Compare(guess, number));
    }
}
