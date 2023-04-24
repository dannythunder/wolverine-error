using Messages.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace Wolverine.Controllers;

[ApiController]
[Route("[controller]")]
public class MediatorController : ControllerBase
{
    private readonly ILogger<MediatorController> _logger;
    private readonly IMessageBus _bus;

    public MediatorController(ILogger<MediatorController> logger, IMessageBus bus)
    {
        _logger = logger;
        _bus = bus;
    }

    [HttpPost]
    public async Task<IActionResult> Post(MediatorCreateItemCommand command)
    {
        await _bus.SendAsync(command);

        return Accepted();
    }
}