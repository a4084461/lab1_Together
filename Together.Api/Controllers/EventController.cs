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
        EventAddResult result =  eventService.add(
            request.name,
            request.coordinator,
            request.place,
            request.lat,
            request.lng,
            request.fee
        );

        AddEventResponse res = new(
            result.id,
            result.name,
            result.coordinator,
            result.place,
            result.lat,
            result.lng,
            result.fee
            );

        return Ok(res);
    }

    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        EventQueryResult[] result = eventService.query(
            request.lat,
            request.lng,
            request.length
        );

        List<QueryEventResponse> events = [];

        foreach (EventQueryResult r in result)
        {
            QueryEventResponse res = new(
                r.name,
                r.coordinator,
                r.place,
                r.lat,
                r.lng,
                r.fee
            );
            events.Add(res);
        }

        // QueryEventResponse[] events = [res, res, res];
        return Ok(events.ToArray());
    }

}