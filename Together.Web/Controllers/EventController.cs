using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;

namespace Together.Web.Controllers;

public class EventController(IEventService ies) : Controller
{
    public readonly IEventService eventService = ies;

    public IActionResult Index()
    {
        EventQueryResult[] result = eventService.query(0, 0, 0);
        return View(result);
    }
}