namespace VivaSphere.Api.Models;

public record JobPosting(
    int Id,
    string Slug,
    string Title,
    string Location,
    string EmploymentType,
    string Department,
    string Description,
    IReadOnlyList<string> Responsibilities,
    IReadOnlyList<string> Requirements,
    DateTime PostedAt
);
