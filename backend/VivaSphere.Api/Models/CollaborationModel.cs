namespace VivaSphere.Api.Models;

public record CollaborationModel(
    int Id,
    string Name,
    string ShortDescription,
    string LongDescription,
    IReadOnlyList<string> Benefits,
    IReadOnlyList<string> Steps
);
