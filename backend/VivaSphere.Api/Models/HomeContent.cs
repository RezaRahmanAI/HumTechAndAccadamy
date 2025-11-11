namespace VivaSphere.Api.Models;

public record HomeContent(
    HeroContent Hero,
    IReadOnlyList<string> TrustedBy,
    IReadOnlyList<CollaborationModel> CollaborationModels,
    IReadOnlyList<Service> Services,
    IReadOnlyList<ProductCaseStudy> Products,
    IReadOnlyList<TechLogo> TechStack,
    IReadOnlyList<Testimonial> Testimonials,
    IReadOnlyList<Industry> Industries,
    IReadOnlyList<WhyChooseUsItem> WhyChooseUs,
    IReadOnlyList<ProcessStep> ProcessSteps,
    IReadOnlyList<FaqItem> Faqs
);

public record HeroContent(
    string Eyebrow,
    string Title,
    string Description,
    string PrimaryCta,
    string SecondaryCta,
    IReadOnlyList<StatItem> Stats,
    string IllustrationUrl
);

public record StatItem(string Label, string Value);

public record WhyChooseUsItem(string Title, string Description, string Icon);

public record ProcessStep(int Step, string Title, string Description);
