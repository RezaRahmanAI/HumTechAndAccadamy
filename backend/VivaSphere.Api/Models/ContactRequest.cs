namespace VivaSphere.Api.Models;

public record ContactRequest(
    int Id,
    string Name,
    string Email,
    string Company,
    string BudgetRange,
    string Message,
    DateTime CreatedAt
);
