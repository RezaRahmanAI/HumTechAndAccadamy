namespace VivaSphere.Api.Models;

public record Service(
    int Id,
    string Slug,
    string Title,
    string Subtitle,
    string Description,
    string Icon,
    string Category,
    string Type,
    IReadOnlyList<string> Highlights,
    IReadOnlyList<ContentSection> Sections
);

public record ContentSection(string Heading, string Body);
