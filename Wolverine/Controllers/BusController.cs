using Microsoft.AspNetCore.Mvc;

namespace Wolverine.Controllers;

[ApiController]
[Route("[controller]")]
public class BusController : ControllerBase
{
    private readonly ILogger<MediatorController> _logger;
    private readonly IMessageBus _bus;

    public BusController(ILogger<MediatorController> logger, IMessageBus bus)
    {
        _logger = logger;
        _bus = bus;
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
        return BadRequest("Not implemented");
    }
}