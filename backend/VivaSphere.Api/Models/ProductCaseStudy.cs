namespace VivaSphere.Api.Models;

public record ProductCaseStudy(
    int Id,
    string Slug,
    string Name,
    string ShortDescription,
    string LongDescription,
    IReadOnlyList<string> TechStack,
    string Industry,
    IReadOnlyList<string> Metrics,
    string HeroImageUrl
);
