using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;
using Together.Contract.Controllers;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController(IEventService eventService) : ControllerBase
{

    private readonly IEventService eventService = eventService;

    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        AddEventResponse res = new(
            Guid.NewGuid(),
            request.name,
            request.coordinator,
            request.place,
            request.lat,
            request.lng,
            request.fee
            );
        return Ok(res);
    }

    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        QueryEventResponse res = new(
            "activity name",
            "Mark Ho",
            "Taipei city hall",
            23.8f,
            100.4f,
            500
         );
        QueryEventResponse[] events = [res, res, res];
        return Ok(events);
    }

}