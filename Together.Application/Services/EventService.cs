namespace Together.Application.Services;

public class EventService : IEventService
{
    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        return new EventAddResult(
            Guid.NewGuid(),
            name,
            coordinator,
            place,
            lat,
            lng,
            fee
        );
        
    }

    public EventQueryResult[] query(float lat, float lng, float length)
    {
        EventQueryResult result = new("name", "coordinator", "Taipei", 0.5f, 0.5f, 300);
        EventQueryResult[] results = [result, result, result];
        return results;
    }
}