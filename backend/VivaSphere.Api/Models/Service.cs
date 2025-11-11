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
    IReadOnlyList<ContentSection> Sections,
    ServicePageContent PageContent
);

public record ContentSection(string Heading, string Body);

public record ServicePageContent(
    string Eyebrow,
    string Lead,
    string PrimaryCtaLabel,
    string SecondaryCtaLabel,
    IReadOnlyList<StatItem> Stats,
    IReadOnlyList<ContentSection> About,
    IReadOnlyList<ServiceBenefit> Benefits,
    ComparisonTable Comparison,
    IReadOnlyList<ServiceProcessStep> Process,
    IReadOnlyList<string> ValueDrivers,
    ContactBlock Contact
);

public record ServiceBenefit(string Title, string Description);

public record ComparisonTable(IReadOnlyList<string> Headers, IReadOnlyList<ComparisonRow> Rows);

public record ComparisonRow(string Attribute, IReadOnlyList<string> Values);

public record ServiceProcessStep(int Step, string Title, string Description);

public record ContactBlock(string Title, string Subtitle, string CtaLabel, string SchedulerUrl);
