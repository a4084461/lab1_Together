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

    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        eventService.add(name, coordinator, place, lat, lng, fee);
        return new RedirectResult(url: "/Event");   
    }

}