using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LinkHub.Api.Database;

[ApiController]
[Route("[controller]")]
public class DevicesController
{
    [HttpGet]
    public string Get()
    {
        return "Hello world";
    }

    [HttpPatch]
    public IActionResult Post()
    {
        return null;
    }
}
