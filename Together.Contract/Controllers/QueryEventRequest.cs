namespace Together.Contract.Controllers;

public record QueryEventRequest(
    float lat,
    float lng,
    float length
);