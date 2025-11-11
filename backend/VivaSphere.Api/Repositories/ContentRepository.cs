using VivaSphere.Api.Models;

namespace VivaSphere.Api.Repositories;

public class ContentRepository
{
    private readonly List<ContactRequest> _contactRequests = new();

    private readonly List<Service> _services;
    private readonly List<CollaborationModel> _collaborationModels;
    private readonly List<ProductCaseStudy> _products;
    private readonly List<TechLogo> _techStack;
    private readonly List<Testimonial> _testimonials;
    private readonly List<Industry> _industries;
    private readonly List<FaqItem> _faqs;
    private readonly List<BlogPost> _blogPosts;
    private readonly List<JobPosting> _careers;

    public ContentRepository()
    {
        _collaborationModels = new List<CollaborationModel>
        {
            new(1, "Team Augmentation", "Scale delivery with embedded experts", "Plug senior engineers into your workflows for predictable delivery.",
                new[] { "Elastic capacity without lengthy hiring", "Battle-tested engineers across web, cloud, and mobile" },
                new[] { "Share skill gaps", "Meet curated experts", "Integrate to rituals", "Review delivery" }),
            new(2, "MVP Development", "Ship core experiences in weeks", "Cross-functional squad to validate market hypotheses quickly.",
                new[] { "Rapid prototyping and discovery", "Iterative releases with measurable outcomes" },
                new[] { "Define north star", "Design solution", "Build increments", "Launch & learn" }),
            new(3, "End-to-End Product Development", "Partner from strategy to scale", "Strategists, designers, and engineers aligned on long-term outcomes.",
                new[] { "Product leadership support", "Automation baked in from day zero" },
                new[] { "Envision", "Architect", "Deliver", "Evolve" }),
            new(4, "Offshore Office Expansion", "Build your nearshore base", "Spin up a dedicated Bangladesh delivery center with our operations support.",
                new[] { "Recruitment, HR, and culture playbooks", "Secure infrastructure & compliance" },
                new[] { "Define footprint", "Select workspace", "Assemble team", "Operate with us" })
        };

        _services = new List<Service>
        {
            new(
                1,
                "team-augmentation",
                "Team Augmentation",
                "Embed senior engineers aligned with your rituals",
                "Elastic squads that integrate with your ceremonies and tools to deliver complex initiatives without sacrificing quality.",
                "🤝",
                "Collaboration",
                "Managed Team",
                new[]
                {
                    "Dedicated team lead and delivery manager",
                    "Flexible ramp up or ramp down",
                    "Secure development environments"
                },
                new[]
                {
                    new ContentSection("Strategic intake", "We assess goals, architecture, and culture to craft the right mix of engineers."),
                    new ContentSection("Embedded delivery", "Our team pairs with your leads, shipping features and sharing context daily."),
                    new ContentSection("Knowledge transfer", "We ensure documentation, automation, and runbooks are handed over cleanly.")
                }
            ),
            new(
                2,
                "end-to-end-development",
                "End-to-End Development",
                "From discovery to post-launch operations",
                "Product strategists, designers, and engineers craft resilient platforms with measurable ROI.",
                "🚀",
                "Delivery",
                "Project Based",
                new[]
                {
                    "Dedicated product strategy support",
                    "Experience design and research",
                    "Automated testing and observability"
                },
                new[]
                {
                    new ContentSection("Discovery", "We align stakeholders, define success metrics, and map the experience."),
                    new ContentSection("Build & iterate", "Sprints focused on releasing value with transparency across every stage."),
                    new ContentSection("Scale", "Optimize performance, launch to new regions, and evolve product-market fit.")
                }
            ),
            new(
                3,
                "mvp-services",
                "MVP Services",
                "Launch market-ready pilots fast",
                "Multi-disciplinary squad that validates your proposition with production-ready software.",
                "⚡",
                "Delivery",
                "Time & Materials",
                new[]
                {
                    "Four-week discovery and roadmap",
                    "Rapid prototyping and testing",
                    "Release automation"
                },
                new[]
                {
                    new ContentSection("Ideation", "We define user journeys, success measures, and technical approach."),
                    new ContentSection("Implementation", "Design systems, engineering, and QA operate in parallel to move fast."),
                    new ContentSection("Launch", "We deploy, monitor, and plan your growth backlog.")
                }
            ),
            new(
                4,
                "offshore-development",
                "Offshore Development",
                "Build your Bangladesh delivery hub",
                "Recruitment, operations, and coaching to spin up a high-performing offshore office.",
                "🌐",
                "Collaboration",
                "Dedicated Center",
                new[]
                {
                    "Talent acquisition & HR support",
                    "Culture and engagement playbooks",
                    "Secure infrastructure & compliance"
                },
                new[]
                {
                    new ContentSection("Launch blueprint", "We define hiring profiles, security, and workflows with your leadership."),
                    new ContentSection("Recruit & onboard", "We source, vet, and onboard talent under your brand."),
                    new ContentSection("Operate & optimize", "Shared governance ensures continuous improvement and retention.")
                }
            ),
            new(
                5,
                "cloud-services",
                "Cloud & Platform Engineering",
                "Operate at scale with resilient infrastructure",
                "Certified cloud engineers modernize and manage infrastructure across Azure and AWS.",
                "☁️",
                "Technology",
                "Retainer",
                new[] { "Cloud cost optimization", "Infrastructure as code", "24/7 monitoring" },
                new[] { new ContentSection("Assess", "Review workloads and reliability targets."), new ContentSection("Implement", "Migrate and modernize workloads."), new ContentSection("Optimize", "Continuous governance and automation.") }
            ),
            new(
                6,
                "data-analytics",
                "Data & Analytics",
                "Unlock insights with trusted pipelines",
                "Data engineers and analysts design governed pipelines, analytics, and ML enablement.",
                "📊",
                "Technology",
                "Retainer",
                new[] { "Centralized data lake", "BI enablement", "Operational dashboards" },
                new[] { new ContentSection("Discover", "Identify KPIs and data sources."), new ContentSection("Model", "Build clean, governed models."), new ContentSection("Adopt", "Enable teams with dashboards and training.") }
            ),
            new(
                7,
                "mobile-development",
                "Mobile App Development",
                "Native and cross-platform excellence",
                "Build high-performing mobile experiences leveraging Flutter, React Native, and Kotlin/Swift teams.",
                "📱",
                "Delivery",
                "Project",
                new[] { "Design systems for mobile", "Performance optimization", "App store management" },
                new[] { new ContentSection("Research", "Understand users and market."), new ContentSection("Design", "Craft intuitive flows."), new ContentSection("Develop", "Release on iOS and Android with automated QA.") }
            ),
            new(
                8,
                "devops-consultation",
                "DevOps & Automation",
                "Reduce lead time with mature pipelines",
                "CI/CD experts automate deployments, observability, and SRE practices.",
                "🛠️",
                "Technology",
                "Retainer",
                new[] { "GitOps pipelines", "Monitoring & alerting", "Resilience engineering" },
                new[] { new ContentSection("Audit", "Review SDLC and tooling."), new ContentSection("Implement", "Introduce pipelines and automation."), new ContentSection("Coach", "Upskill teams on DevOps culture.") }
            ),
            new(
                9,
                "ux-ui-design",
                "Product Design",
                "Human-centered product design",
                "Strategic designers craft accessible journeys and design systems aligned to business goals.",
                "🎨",
                "Design",
                "Project",
                new[] { "Design systems", "User research", "Product strategy" },
                new[] { new ContentSection("Discover", "Map user needs and product vision."), new ContentSection("Design", "Prototype core experiences."), new ContentSection("Refine", "Validate with users and handoff to engineering.") }
            )
        };

        _products = new List<ProductCaseStudy>
        {
            new(1, "aurora-pay", "Aurora Pay", "Fintech platform processing real-time remittances across APAC.",
                "Built a resilient payment core with automated compliance workflows and real-time monitoring dashboards.",
                new[] { "Azure", ".NET", "Angular", "Azure Service Bus" },
                "Fintech",
                new[] { "99.98% platform uptime", "35% faster partner onboarding", "PCI-DSS compliant" },
                ""),
            new(2, "northwind-insights", "Northwind Insights", "AI-assisted analytics hub for logistics enterprises.",
                "Delivered governed data pipelines, machine learning forecasting, and interactive dashboards for fleet operators.",
                new[] { "Python", "Databricks", "Azure Synapse", "Power BI" },
                "Logistics",
                new[] { "Improved ETA accuracy by 27%", "Unified 12 data sources", "Automated anomaly alerts" },
                ""),
            new(3, "atlas-learning", "Atlas Learning", "Immersive learning platform for global universities.",
                "Scaled a multi-tenant learning management system with live collaboration and offline-first experiences.",
                new[] { "React", "Node.js", "PostgreSQL", "AWS" },
                "EdTech",
                new[] { "Serving 500k+ learners", "Latency reduced by 45%", "Accessibility AA compliant" },
                "")
        };

        _techStack = new List<TechLogo>
        {
            new(1, "Angular", "Frontend", ""),
            new(2, "React", "Frontend", ""),
            new(3, "Vue", "Frontend", ""),
            new(4, ".NET", "Backend", ""),
            new(5, "Node.js", "Backend", ""),
            new(6, "Go", "Backend", ""),
            new(7, "Python", "Backend", ""),
            new(8, "Java", "Backend", ""),
            new(9, "AWS", "Cloud", ""),
            new(10, "Azure", "Cloud", ""),
            new(11, "GCP", "Cloud", ""),
            new(12, "Flutter", "Mobile", "")
        };

        _testimonials = new List<Testimonial>
        {
            new(1, "Nadia Rahman", "CTO", "Trident Finserve", "VivaSphere embedded seamlessly with our team and delivered regulated fintech components ahead of schedule.", ""),
            new(2, "Aaron Lim", "Head of Digital", "Strato Airlines", "Their product mindset ensured every release connected to a measurable business outcome.", ""),
            new(3, "Farhan Chowdhury", "Founder", "Pulse Health", "We validated our MVP in 12 weeks and closed our seed round with confidence.", "")
        };

        _industries = new List<Industry>
        {
            new(1, "Finance", "Secure banking, remittance, and fintech platforms.", "💳"),
            new(2, "E-Commerce", "Omnichannel commerce and logistics orchestration.", "🛒"),
            new(3, "Telecom", "Carrier-grade provisioning and self-care portals.", "📡"),
            new(4, "Health & Wellness", "Connected care and digital health ecosystems.", "🩺"),
            new(5, "Logistics", "Global freight visibility and optimization.", "🚚"),
            new(6, "Government", "Citizen services and secure portals.", "🏛️"),
            new(7, "Gaming", "Real-time multiplayer experiences.", "🎮"),
            new(8, "Real Estate", "Property search and management platforms.", "🏢")
        };

        _faqs = new List<FaqItem>
        {
            new(1, "How quickly can a team start?", "We typically present vetted engineers within five business days and can kick off in two weeks.", "Engagement"),
            new(2, "Do you work in overlapping time zones?", "Yes, we structure pods to overlap at least four hours with your core team.", "Delivery"),
            new(3, "Can you work with existing vendors?", "We regularly collaborate with in-house teams and external vendors to align delivery.", "Collaboration"),
            new(4, "How do you ensure quality?", "Automated testing, code reviews, and observability are standard across all engagements.", "Quality"),
            new(5, "What security standards do you follow?", "We adhere to ISO 27001 controls and implement secure development practices.", "Security")
        };

        _blogPosts = new List<BlogPost>
        {
            new(1, "scaling-observability", "Scaling observability across distributed platforms", "A playbook for modernizing monitoring with open telemetry.",
                "We share our approach to instrumenting polyglot services using OpenTelemetry, central logging, and SRE scorecards.", "Cloud", DateTime.UtcNow.AddDays(-12), ""),
            new(2, "bangladesh-engineering-talent", "Building global products from Bangladesh", "How distributed Bangladeshi teams deliver enterprise-grade software.",
                "Insights from working with clients across four continents and establishing co-located pods for complex programs.", ".NET", DateTime.UtcNow.AddDays(-30), ""),
            new(3, "ux-for-fintech", "Designing trust in fintech onboarding", "Patterns that simplify compliance without hurting conversions.",
                "Explore UX strategies that balance compliance, identity verification, and delightful onboarding for financial apps.", "AI", DateTime.UtcNow.AddDays(-45), "")
        };

        _careers = new List<JobPosting>
        {
            new(1, "senior-backend-engineer", "Senior Backend Engineer", "Dhaka, Bangladesh", "Full-time", "Engineering",
                "Own distributed services powering fintech and logistics platforms.",
                new[] { "Design event-driven architecture", "Ship resilient APIs", "Mentor teammates" },
                new[] { "6+ years with .NET or Go", "Experience with cloud infrastructure", "Strong communication" },
                DateTime.UtcNow.AddDays(-10)),
            new(2, "product-designer", "Product Designer", "Remote", "Full-time", "Design",
                "Craft human-centered experiences for web and mobile applications.",
                new[] { "Lead discovery workshops", "Design wireframes and prototypes", "Collaborate with engineers" },
                new[] { "4+ years designing digital products", "Proficient with Figma", "Strong research chops" },
                DateTime.UtcNow.AddDays(-5))
        };
    }

    public HomeContent GetHome() => new(
        new HeroContent(
            "Custom software partner",
            "We assemble world-class product teams on demand",
            "VivaSphere delivers resilient digital platforms with elite engineers, designers, and strategists from Bangladesh.",
            "Hire a Dedicated Team",
            "View Company Profile",
            new[]
            {
                new StatItem("Top talents", "50+"),
                new StatItem("Projects", "100+"),
                new StatItem("Years shipping", "10+"),
                new StatItem("Tech stack", "20+")
            },
            ""
        ),
        new[] { "Trident", "Northwind", "SummitPay", "Orbit Logistics", "Skyline Media", "Pulse Health" },
        _collaborationModels,
        _services,
        _products,
        _techStack,
        _testimonials,
        _industries,
        new[]
        {
            new WhyChooseUsItem("Professional developers", "Only senior engineers with proven delivery experience join our pods.", "👩‍💻"),
            new WhyChooseUsItem("Dedicated account specialists", "Client partners ensure proactive communication and remove blockers.", "🎯"),
            new WhyChooseUsItem("Flexible strategy", "Engagements adapt from discovery to scale without losing momentum.", "🧭"),
            new WhyChooseUsItem("On-time delivery", "Transparent reporting and automation keep launches on track.", "⏱️")
        },
        new[]
        {
            new ProcessStep(1, "Strategy session", "Align on objectives, scope, and the right team mix."),
            new ProcessStep(2, "Shape your team", "Select curated experts and define rituals."),
            new ProcessStep(3, "Execute & iterate", "Ship increments with clear metrics."),
            new ProcessStep(4, "Scale & support", "Optimize, transfer knowledge, and grow capability.")
        },
        _faqs
    );

    public IReadOnlyList<Service> GetServices() => _services;
    public Service? GetService(string slug) => _services.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<ProductCaseStudy> GetProducts() => _products;
    public ProductCaseStudy? GetProduct(string slug) => _products.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public IReadOnlyList<TechLogo> GetTechStack() => _techStack;
    public IReadOnlyList<Testimonial> GetTestimonials() => _testimonials;
    public IReadOnlyList<Industry> GetIndustries() => _industries;
    public IReadOnlyList<FaqItem> GetFaq() => _faqs;
    public IReadOnlyList<BlogPost> GetBlogPosts() => _blogPosts;
    public BlogPost? GetBlogPost(string slug) => _blogPosts.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
    public IReadOnlyList<JobPosting> GetCareers() => _careers;
    public JobPosting? GetCareer(string slug) => _careers.FirstOrDefault(c => c.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public ContactRequest CreateContactRequest(ContactRequestDto dto)
    {
        var request = new ContactRequest(
            _contactRequests.Count + 1,
            dto.Name,
            dto.Email,
            dto.Company,
            dto.BudgetRange,
            dto.Message,
            DateTime.UtcNow
        );
        _contactRequests.Add(request);
        return request;
    }
}
