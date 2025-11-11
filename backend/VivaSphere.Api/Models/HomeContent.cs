namespace VivaSphere.Api.Models;

public record HomeContent(
    HeroContent Hero,
    TrustedBySection TrustedBy,
    IReadOnlyList<CollaborationModel> CollaborationModels,
    IReadOnlyList<Service> Services,
    IReadOnlyList<ProductCaseStudy> FeaturedProducts,
    IReadOnlyList<ProductSpotlight> ProductSpotlights,
    TechStackSection TechStack,
    TestimonialSection Testimonials,
    IndustrySection Industries,
    ExcellenceShowcase Excellence,
    IReadOnlyList<WhyChooseUsItem> WhyChooseUs,
    IReadOnlyList<TeamMember> TeamMembers,
    ProcessSection Process,
    IReadOnlyList<FaqItem> Faqs,
    IReadOnlyList<BlogPost> RecentBlogs,
    FinalCtaContent FinalCta
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

public record TrustedBySection(string Eyebrow, string Description, IReadOnlyList<string> Logos);

public record TechStackSection(string Title, string Description, IReadOnlyList<TechLogo> Logos);

public record TestimonialSection(string Eyebrow, string Title, string Description, string RatingLabel, IReadOnlyList<Testimonial> Items);

public record IndustrySection(string Eyebrow, string Title, string Description, IReadOnlyList<Industry> Items);

public record ExcellenceShowcase(string Eyebrow, string Title, string Description, IReadOnlyList<AwardBadge> Badges);

public record AwardBadge(string Name, string Description, string LogoUrl, string Link);

public record TeamMember(int Id, string Name, string Title, string Bio, string PhotoUrl);

public record ProcessSection(string Eyebrow, string Title, string Description, IReadOnlyList<ProcessStep> Steps, ProcessCallToAction Cta);

public record ProcessCallToAction(string Label, string Url);

public record ProductSpotlight(int Id, string Name, string Description, string Industry, string Link);

public record FinalCtaContent(
    string Eyebrow,
    string Title,
    string Description,
    string PrimaryCtaLabel,
    string PrimaryCtaLink,
    string SecondaryCtaLabel,
    string SecondaryCtaLink,
    string IllustrationUrl
);
