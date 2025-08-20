namespace Together.Contract.Controllers;

public record AddEventResponse(
    Guid id,
    string name,
    string coordinator,
    string place,
    float lat,
    float lng,
    int fee
);