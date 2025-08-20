namespace Together.Application.Services;

public record EventAddResult(
    Guid id,
    string name,
    string coordinator,
    string place,
    float lat,
    float lng,
    int fee
);