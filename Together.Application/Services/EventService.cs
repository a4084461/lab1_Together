using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Application.Services;

public class EventService(IEventRepository repository) : IEventService
{
    private readonly IEventRepository repository = repository;

    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {

        var event1 = new Event
        {
            Name = name,
            Coordinator = coordinator,
            Place = place,
            Lat = lat,
            Lng = lng,
            Fee = fee
        };
        repository.AddEvent(event1);
        return new EventAddResult(
            event1.Id,
            event1.Name,
            event1.Coordinator,
            event1.Place,
            event1.Lat,
            event1.Lng,
            event1.Fee
        );

    }

    public EventQueryResult[] query(float lat, float lng, float length)
    {
        List<EventQueryResult> results = [];
        foreach (var r in repository.GetAll())
        {
            EventQueryResult result = new EventQueryResult(
                r.Name,
                r.Coordinator,
                r.Place,
                r.Lat,
                r.Lng,
                r.Fee

            );
            results.Add(result);
        }

        // EventQueryResult result = new("name", "coordinator", "Taipei", 0.5f, 0.5f, 300);
        // EventQueryResult[] results = [result, result, result];
        return results.ToArray();
    }
}