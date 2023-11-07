using ECTPFinalProject.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers;

[ApiController]
[Route("events")]
public class EventController : ControllerBase
{
    private readonly ILogger<EventController> _logger;

    public EventController(ILogger<EventController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Event> Get()
    {
        var list = new List<Event>();
        return list;
    }
}