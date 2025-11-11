using System.Collections.Generic;
using System.Linq;
using VivaSphere.Api.Models;

namespace VivaSphere.Api.Repositories;

public class ContentRepository
{
    private readonly List<ContactRequest> _contactRequests = new();

    private readonly List<Service> _services;
    private readonly List<CollaborationModel> _collaborationModels;
    private readonly List<ProductCaseStudy> _products;
    private readonly List<ProductSpotlight> _productSpotlights;
    private readonly List<TechLogo> _techStack;
    private readonly List<Testimonial> _testimonials;
    private readonly List<Industry> _industries;
    private readonly List<TeamMember> _teamMembers;
    private readonly List<WhyChooseUsItem> _whyChooseUs;
    private readonly ProcessSection _processSection;
    private readonly ExcellenceShowcase _excellence;
    private readonly TrustedBySection _trustedBy;
    private readonly TechStackSection _techStackSection;
    private readonly TestimonialSection _testimonialSection;
    private readonly IndustrySection _industrySection;
    private readonly FinalCtaContent _finalCta;
    private readonly List<FaqItem> _faqs;
    private readonly List<BlogPost> _blogPosts;
    private readonly List<JobPosting> _careers;

    public ContentRepository()
    {
        _collaborationModels = new List<CollaborationModel>
        {
            new(1, "Team Augmentation", "Elastic pods embedded in your rituals", "Plug experienced engineers into your ceremonies to expand delivery while your core team stays focused on strategy.",
                new[] { "Scale capacity in days, not months", "Domain-aligned specialists across product, web, cloud, and data" },
                new[] { "Share priorities", "Review curated experts", "Integrate into tooling", "Track sprint outcomes" }),
            new(2, "MVP Services", "Launch a validated product in 90 days", "Cross-functional squads prototype, iterate, and launch market-ready pilots with measurable learning loops.",
                new[] { "UX research and lean discovery", "Technical foundations ready for scale" },
                new[] { "Shape the vision", "Design experiences", "Ship increments", "Measure & iterate" }),
            new(3, "End-to-End Development", "From concept to global rollout", "Product strategists, designers, and platform engineers co-own outcomes from roadmap planning through post-launch optimization.",
                new[] { "Product leadership alignment", "Automation, QA, and observability baked in" },
                new[] { "Discover", "Architect", "Deliver", "Evolve" }),
            new(4, "Offshore Office Expansion", "Build your Bangladesh delivery hub", "Establish a branded offshore center with our recruitment, HR, and operations guidance to create a long-term capability.",
                new[] { "Hiring playbooks and cultural onboarding", "Secure infrastructure, compliance, and administration" },
                new[] { "Set objectives", "Design operating model", "Hire & onboard", "Run continuous improvement" })
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
                },
                new ServicePageContent(
                    "IT Team Augmentation",
                    "Extend your delivery capacity with specialists who adopt your ceremonies, toolchain, and coding standards from day one.",
                    "Hire the Best Team",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Available experts", "50+"),
                        new StatItem("Kickoff speed", "2 weeks"),
                        new StatItem("Avg. engagement", "18 months")
                    },
                    new[]
                    {
                        new ContentSection("About Team Augmentation", "Product leaders choose VivaSphere when they need additional velocity without losing control of roadmap decisions."),
                        new ContentSection("How we partner", "Delivery leads coordinate onboarding, communication cadences, and performance metrics so your augmented squad performs like an in-house unit.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Access domain specialists", "Tap senior engineers screened for architecture, communication, and product sense."),
                        new ServiceBenefit("Governed onboarding", "Two-week integration plan covering tooling, security, and documentation."),
                        new ServiceBenefit("Transparent delivery", "Daily stand-ups, shared dashboards, and written updates keep stakeholders aligned."),
                        new ServiceBenefit("Flexible scaling", "Adjust squad size in sync with budget, releases, or funding milestones."),
                        new ServiceBenefit("Knowledge continuity", "Retention programs and structured handovers preserve context.")
                    },
                    BuildComparison("Team Augmentation", "product and platform delivery"),
                    BuildProcess(
                        "Clarify goals, roles, and domain knowledge so we can curate the right engineers.",
                        "Share profiles, schedule interviews, and finalize the ideal squad composition.",
                        "Engineers join your rituals, contribute code, and surface improvements from the first sprint.",
                        "Quarterly reviews and succession planning maintain long-term momentum."),
                    new[]
                    {
                        "Embedded delivery manager for proactive communication",
                        "Security and compliance aligned to ISO 27001 controls",
                        "Regional overlap for collaboration across time zones",
                        "Continuous improvement suggestions backed by metrics"
                    },
                    new ContactBlock(
                        "Plan your augmented squad",
                        "Tell us about your roadmap and the skills you need. We share vetted profiles within 48 hours.",
                        "Schedule a Call",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                },
                new ServicePageContent(
                    "End-to-End Software Delivery",
                    "Own the entire product lifecycle with a squad that blends product strategy, UX, engineering, QA, and DevOps.",
                    "Start a Project",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Products launched", "40+"),
                        new StatItem("Time to MVP", "12 weeks"),
                        new StatItem("Core team size", "8-12 experts")
                    },
                    new[]
                    {
                        new ContentSection("About End-to-End Delivery", "We translate your strategy into a measurable roadmap, then ship customer-ready increments every sprint."),
                        new ContentSection("Operational excellence", "Release automation, observability, and change management ensure a smooth transition from build to run.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Product strategy leadership", "Facilitate discovery sessions, define KPIs, and maintain a prioritized backlog."),
                        new ServiceBenefit("Design systems & research", "UX researchers and designers craft evidence-based journeys."),
                        new ServiceBenefit("Robust engineering", "Polyglot engineers build scalable, secure architectures tuned for your workloads."),
                        new ServiceBenefit("Quality automation", "Automated testing, CI/CD, and observability reduce release risk."),
                        new ServiceBenefit("Operational handover", "Documentation, playbooks, and training equip your internal teams.")
                    },
                    BuildComparison("End-to-End Development", "full product ownership"),
                    BuildProcess(
                        "Kick off strategy workshops to understand users, constraints, and success metrics.",
                        "Create blueprints, experience flows, and technical architecture validated with stakeholders.",
                        "Run incremental sprints delivering working software with observability built in.",
                        "Plan scale-up initiatives, optimize performance, and support handover or co-delivery."),
                    new[]
                    {
                        "Dedicated product lead as single point of accountability",
                        "Research-backed UX and design systems",
                        "Automated compliance and security reviews",
                        "Post-launch analytics and optimization roadmap"
                    },
                    new ContactBlock(
                        "Design your end-to-end team",
                        "Share scope, timeline, and existing assets to receive a proposal tailored to your goals.",
                        "Book a Consultation",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                },
                new ServicePageContent(
                    "Minimum Viable Product Squads",
                    "Validate your idea with a production-ready MVP that delights early adopters and attracts investors.",
                    "Scope Your MVP",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Validated launches", "25+"),
                        new StatItem("Discovery sprint", "4 weeks"),
                        new StatItem("Average budget", "$60k-$120k")
                    },
                    new[]
                    {
                        new ContentSection("About MVP Services", "We combine lean discovery with rapid engineering to test product-market fit and gather actionable insight."),
                        new ContentSection("Outcome focus", "Each release includes analytics, experiment plans, and documentation to scale beyond the MVP stage.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Lean product strategy", "Define personas, journeys, and KPIs to prioritize the right scope."),
                        new ServiceBenefit("Design-led prototyping", "Clickable prototypes validate value propositions before build."),
                        new ServiceBenefit("Parallel build & QA", "Developers, QA, and DevOps collaborate to shorten release cycles."),
                        new ServiceBenefit("Investor-ready artifacts", "Pitch support, architecture decks, and measurement frameworks."),
                        new ServiceBenefit("Transition to scale", "Backlog grooming and hiring support for post-MVP expansion.")
                    },
                    BuildComparison("MVP Services", "launching new digital products"),
                    BuildProcess(
                        "Product strategists gather requirements, target audience insights, and success metrics.",
                        "We create UX flows, technical blueprint, and release milestones validated with stakeholders.",
                        "Sprints deliver working increments with QA, analytics, and feedback loops.",
                        "Handover growth backlog, scaling recommendations, and funding-ready documentation."),
                    new[]
                    {
                        "Discovery workshops facilitated by product strategists",
                        "Design system foundations for future releases",
                        "Analytics instrumentation included at launch",
                        "Optional handover to long-term team"
                    },
                    new ContactBlock(
                        "Discuss your MVP scope",
                        "We’ll assess your concept and outline a delivery plan with timeline and investment estimate.",
                        "Plan an MVP Sprint",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                },
                new ServicePageContent(
                    "Offshore Development Center",
                    "Stand up a branded Bangladesh office with recruitment, HR, and delivery governance handled for you.",
                    "Build Your Offshore Team",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Engineers hired", "120+"),
                        new StatItem("Retention rate", "94%"),
                        new StatItem("Setup timeline", "8 weeks")
                    },
                    new[]
                    {
                        new ContentSection("About Offshore Development", "We act as your on-the-ground partner to establish a compliant, culturally aligned team that represents your brand."),
                        new ContentSection("Operations partnership", "From entity setup to workspace management, we help you focus on product while we manage local operations.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Employer branding", "Talent marketing and recruitment campaigns tailored to your value proposition."),
                        new ServiceBenefit("Secure facilities", "Physical and digital security controls aligned to ISO and SOC2."),
                        new ServiceBenefit("People operations", "HR, payroll, and culture programs handled by local specialists."),
                        new ServiceBenefit("Leadership coaching", "Onboarding and continuous coaching align teams to your culture."),
                        new ServiceBenefit("Scalable governance", "KPIs, reviews, and retention programs to support sustainable growth.")
                    },
                    BuildComparison("Offshore Development", "building distributed delivery centers"),
                    BuildProcess(
                        "Define headcount plan, success metrics, and compliance requirements.",
                        "Design workspace, security controls, and recruitment campaigns.",
                        "Interview and onboard talent under your brand with our HR support.",
                        "Operate with shared governance, retention programs, and continuous improvement."),
                    new[]
                    {
                        "Local legal, payroll, and HR administration",
                        "English-proficient engineers with global delivery experience",
                        "Culture programs that mirror your headquarters",
                        "Transparent cost model with predictable monthly fee"
                    },
                    new ContactBlock(
                        "Map your offshore roadmap",
                        "Share growth targets and governance needs. We prepare a tailored offshore build-out plan.",
                        "Plan Your Expansion",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                new[] { new ContentSection("Assess", "Review workloads and reliability targets."), new ContentSection("Implement", "Migrate and modernize workloads."), new ContentSection("Optimize", "Continuous governance and automation.") },
                new ServicePageContent(
                    "Cloud & Platform Engineering",
                    "Modernize infrastructure with platform engineers who combine IaC, observability, and SRE practices.",
                    "Review Cloud Readiness",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Managed workloads", "70+"),
                        new StatItem("Cost savings", "30% avg"),
                        new StatItem("Incident reduction", "40%")
                    },
                    new[]
                    {
                        new ContentSection("About the service", "We partner with your architects to migrate, optimize, and run mission-critical workloads across Azure and AWS."),
                        new ContentSection("Reliability mindset", "Our SRE practice ensures automation, monitoring, and clear runbooks for every environment.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Cloud economics", "Rightsize infrastructure and leverage reserved instances for predictable spend."),
                        new ServiceBenefit("Infrastructure as code", "Terraform and Bicep modules standardize environments across teams."),
                        new ServiceBenefit("Observability", "Unified logging, metrics, and alerting with actionable SLOs."),
                        new ServiceBenefit("Security automation", "Guardrails, policy as code, and compliance dashboards."),
                        new ServiceBenefit("24/7 support", "Follow-the-sun engineers to maintain SLAs.")
                    },
                    BuildComparison("Cloud Engineering", "cloud modernization"),
                    BuildProcess(
                        "Assess current workloads, objectives, and compliance needs.",
                        "Design landing zones, IaC templates, and migration roadmap.",
                        "Implement automation, monitoring, and resilience patterns.",
                        "Operate continuous governance and optimization cycles."),
                    new[]
                    {
                        "Azure and AWS certified engineers",
                        "Proactive cost and performance reporting",
                        "Runbooks and playbooks for your internal teams",
                        "Joint governance rituals with leadership"
                    },
                    new ContactBlock(
                        "Schedule a platform review",
                        "Share your environment inventory to receive a modernization roadmap and investment range.",
                        "Book Infrastructure Audit",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                new[] { new ContentSection("Discover", "Identify KPIs and data sources."), new ContentSection("Model", "Build clean, governed models."), new ContentSection("Adopt", "Enable teams with dashboards and training.") },
                new ServicePageContent(
                    "Data Engineering & Analytics",
                    "Transform fragmented data into governed insights with modern data platform practices.",
                    "Plan a Data Sprint",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Pipelines orchestrated", "150+"),
                        new StatItem("BI adoption", "3x"),
                        new StatItem("ML readiness", "6 weeks")
                    },
                    new[]
                    {
                        new ContentSection("About the service", "Our data practice covers ingestion, modeling, analytics, and enablement so teams can make faster decisions."),
                        new ContentSection("Outcome driven", "Dashboards and models are tied to measurable KPIs and operational workflows.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Modern data stack", "Databricks, Snowflake, Synapse, and dbt specialists."),
                        new ServiceBenefit("Trusted governance", "Cataloging, lineage, and role-based access built-in."),
                        new ServiceBenefit("Analytics enablement", "Self-service dashboards and training for business teams."),
                        new ServiceBenefit("Advanced analytics", "Feature stores and ML pipelines accelerate experimentation."),
                        new ServiceBenefit("Change management", "Adoption plans ensure insights turn into action.")
                    },
                    BuildComparison("Data & Analytics", "data platform modernization"),
                    BuildProcess(
                        "Align on KPIs, data sources, and compliance needs.",
                        "Design architecture, ingestion flows, and data models.",
                        "Implement pipelines, dashboards, and governance tooling.",
                        "Upskill teams, monitor usage, and iterate on insights."),
                    new[]
                    {
                        "Analytics strategists and engineers collaborating end-to-end",
                        "Documentation, playbooks, and training sessions",
                        "Automation reduces manual reporting",
                        "Support for hybrid and multi-cloud setups"
                    },
                    new ContactBlock(
                        "Kickstart your data roadmap",
                        "Share your analytics goals to receive a modernization approach and delivery estimate.",
                        "Book Data Consultation",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                new[] { new ContentSection("Research", "Understand users and market."), new ContentSection("Design", "Craft intuitive flows."), new ContentSection("Develop", "Release on iOS and Android with automated QA.") },
                new ServicePageContent(
                    "Mobile Application Delivery",
                    "Craft native and cross-platform apps that balance performance, usability, and compliance for global audiences.",
                    "Launch a Mobile Squad",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Apps shipped", "60+"),
                        new StatItem("Store rating", "4.7 avg"),
                        new StatItem("Release cadence", "2 weeks")
                    },
                    new[]
                    {
                        new ContentSection("About mobile delivery", "We support product teams with discovery, design, engineering, and release operations for mobile experiences."),
                        new ContentSection("Platform coverage", "Flutter, React Native, Kotlin, and Swift engineers ensure the right technology fit for your roadmap.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Experience research", "Contextual research and analytics inform mobile journeys."),
                        new ServiceBenefit("Design systems", "Component libraries and motion guidelines unify your brand."),
                        new ServiceBenefit("Performance engineering", "Profiling, offline readiness, and accessibility baked in."),
                        new ServiceBenefit("Release management", "App store submission, beta distribution, and analytics setup."),
                        new ServiceBenefit("Continuous optimization", "Experimentation frameworks to drive retention and conversion.")
                    },
                    BuildComparison("Mobile Development", "mobile product delivery"),
                    BuildProcess(
                        "Clarify goals, platforms, and KPIs for your mobile experience.",
                        "Design UX flows, visual language, and architecture.",
                        "Develop features with automated testing and analytics.",
                        "Launch, monitor, and iterate with growth experiments."),
                    new[]
                    {
                        "Dedicated design and engineering leads",
                        "Device labs and automated test suites",
                        "Analytics instrumentation and crash monitoring",
                        "Support for localization and compliance reviews"
                    },
                    new ContactBlock(
                        "Plan your mobile launch",
                        "Share user journeys and target platforms for a tailored squad recommendation.",
                        "Book Mobile Discovery",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                new[] { new ContentSection("Audit", "Review SDLC and tooling."), new ContentSection("Implement", "Introduce pipelines and automation."), new ContentSection("Coach", "Upskill teams on DevOps culture.") },
                new ServicePageContent(
                    "DevOps & Automation",
                    "Reduce lead time and increase reliability with pipelines, observability, and SRE coaching.",
                    "Assess DevOps Maturity",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Deploy frequency", "5x faster"),
                        new StatItem("Change failure rate", "-45%"),
                        new StatItem("Recovery time", "<30 mins")
                    },
                    new[]
                    {
                        new ContentSection("About the service", "We evaluate your SDLC, design automation strategy, and implement toolchains that accelerate delivery."),
                        new ContentSection("Culture focus", "Coaching ensures your teams adopt DevOps practices that stick." )
                    },
                    new[]
                    {
                        new ServiceBenefit("Pipeline automation", "CI/CD pipelines with policy checks and automated approvals."),
                        new ServiceBenefit("Observability", "Dashboards, alerting, and SLOs aligned to business impact."),
                        new ServiceBenefit("Environment management", "GitOps and infrastructure as code keep environments consistent."),
                        new ServiceBenefit("SRE coaching", "Workshops and pairing embed reliability best practices."),
                        new ServiceBenefit("Toolchain integration", "Connect testing, security, and release tooling for end-to-end visibility.")
                    },
                    BuildComparison("DevOps & Automation", "continuous delivery"),
                    BuildProcess(
                        "Assess SDLC, tooling, and organizational goals.",
                        "Design roadmap covering pipelines, monitoring, and roles.",
                        "Implement automation, observability, and guardrails.",
                        "Coach teams, review metrics, and iterate on improvements."),
                    new[]
                    {
                        "Vendor-neutral tooling recommendations",
                        "Security and compliance guardrails",
                        "Blameless postmortems and feedback loops",
                        "Integrated documentation and onboarding kits"
                    },
                    new ContactBlock(
                        "Upgrade your delivery pipeline",
                        "Let’s review your current SDLC and outline improvements with measurable ROI.",
                        "Book DevOps Review",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
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
                new[] { new ContentSection("Discover", "Map user needs and product vision."), new ContentSection("Design", "Prototype core experiences."), new ContentSection("Refine", "Validate with users and handoff to engineering.") },
                new ServicePageContent(
                    "Product Design & Research",
                    "Bring clarity to complex problems with design leaders who marry research, strategy, and visual excellence.",
                    "Engage Design Experts",
                    "Back to Services",
                    new[]
                    {
                        new StatItem("Design systems launched", "20+"),
                        new StatItem("Research sessions", "500+"),
                        new StatItem("Accessibility score", "AA compliant")
                    },
                    new[]
                    {
                        new ContentSection("About the service", "Our designers partner with stakeholders to translate insights into intuitive products."),
                        new ContentSection("Alignment", "Working closely with engineering ensures seamless handover and consistent delivery.")
                    },
                    new[]
                    {
                        new ServiceBenefit("Strategic discovery", "Product workshops surface goals, risks, and measures of success."),
                        new ServiceBenefit("Research-led decisions", "Interviews, usability tests, and analytics inform every iteration."),
                        new ServiceBenefit("Design systems", "Reusable components and documentation speed up future releases."),
                        new ServiceBenefit("Inclusive experiences", "Accessibility, localization, and compliance are addressed early."),
                        new ServiceBenefit("Collaboration rituals", "Daily syncs with product and engineering keep delivery smooth.")
                    },
                    BuildComparison("Product Design", "experience strategy"),
                    BuildProcess(
                        "Run discovery to understand users, business outcomes, and constraints.",
                        "Prototype journeys, information architecture, and visual direction.",
                        "Validate with users, integrate feedback, and refine flows.",
                        "Support handover, QA, and iteration post-launch."),
                    new[]
                    {
                        "Design leadership embedded with stakeholders",
                        "Collaboration with research and analytics teams",
                        "Detailed design specs and Figma libraries",
                        "Support for motion, branding, and marketing collateral"
                    },
                    new ContactBlock(
                        "Elevate your product experience",
                        "Share your product goals so we can assemble a design pod aligned to your roadmap.",
                        "Book Design Consultation",
                        "https://calendly.com/vivasphere/intro-call"
                    )
                )
            )
        };

        _products = new List<ProductCaseStudy>
        {
            new(1, "aurora-pay", "Aurora Pay", "Fintech platform processing real-time remittances across APAC.",
                "Built a resilient payment core with automated compliance workflows and live monitoring dashboards.",
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
                ""),
            new(4, "helios-energy-console", "Helios Energy Console", "Operations cockpit for renewable energy providers.",
                "Implemented predictive maintenance, IoT integrations, and investor reporting in a single secure portal.",
                new[] { "Go", "gRPC", "Kafka", "Svelte" },
                "Energy",
                new[] { "Down-time reduced by 32%", "Single source of truth for 15 plants", "Automated investor updates" },
                "")
        };

        _productSpotlights = new List<ProductSpotlight>
        {
            new(1, "Mercury Fleet", "Global shipping network with live ETA tracking for 28 countries.", "Logistics", "/products/northwind-insights"),
            new(2, "Summit Coach", "Coaching marketplace enabling subscription programs for wellness brands.", "Health & Wellness", "/products/atlas-learning"),
            new(3, "Lumen Retail OS", "Unified inventory, POS, and analytics suite for omnichannel retailers.", "Retail", "/products/aurora-pay"),
            new(4, "Orbit Media Cloud", "Adtech supply-side platform with privacy-first data pipelines.", "Media", "/products/helios-energy-console")
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
            new(12, "Flutter", "Mobile", ""),
            new(13, "Kotlin", "Mobile", ""),
            new(14, "Swift", "Mobile", ""),
            new(15, "PostgreSQL", "Database", ""),
            new(16, "MongoDB", "Database", "")
        };

        _testimonials = new List<Testimonial>
        {
            new(1, "Nadia Rahman", "CTO", "Trident Finserve", "VivaSphere embedded seamlessly with our team and delivered regulated fintech components ahead of schedule.", ""),
            new(2, "Aaron Lim", "Head of Digital", "Strato Airlines", "Their product mindset ensured every release connected to a measurable business outcome.", ""),
            new(3, "Farhan Chowdhury", "Founder", "Pulse Health", "We validated our MVP in 12 weeks and closed our seed round with confidence.", "")
        };

        _industries = new List<Industry>
        {
            new(1, "Finance & Banking", "Secure banking, remittance, and fintech platforms.", "💳"),
            new(2, "E-commerce", "Omnichannel commerce and fulfillment orchestration.", "🛒"),
            new(3, "Telecom", "Carrier-grade provisioning and self-care portals.", "📡"),
            new(4, "Real Estate", "Property search, leasing, and asset management.", "🏢"),
            new(5, "Software & SaaS", "B2B and B2C platforms delivering subscription experiences.", "💼"),
            new(6, "Health & Fitness", "Connected care, telemedicine, and wellness ecosystems.", "🩺"),
            new(7, "Automotive", "Connected vehicle services and dealer enablement.", "🚗"),
            new(8, "Logistics", "Global freight visibility and optimization.", "🚚"),
            new(9, "Photo & Video", "Media collaboration, streaming, and DAM solutions.", "📸"),
            new(10, "Business Services", "Workflow automation for operations and HR teams.", "🗂️"),
            new(11, "Startups", "Seed to growth-stage founders validating new products.", "🚀"),
            new(12, "AR / VR", "Immersive training and experiential marketing platforms.", "🕶️"),
            new(13, "Legal", "Digital case management and compliance tooling.", "⚖️"),
            new(14, "Non-profit", "Impact tracking and donor engagement platforms.", "🤝"),
            new(15, "Government & Public Sector", "Citizen portals and service delivery modernization.", "🏛️"),
            new(16, "Sports & Fitness", "Fan engagement and high-performance training apps.", "🏅"),
            new(17, "Gaming", "Real-time multiplayer and backend services.", "🎮"),
            new(18, "Fashion & Apparel", "D2C experiences and digital showrooms.", "👗"),
            new(19, "Energy & Utilities", "Grid monitoring, billing, and sustainability dashboards.", "⚡"),
            new(20, "Agriculture", "Smart farming, supply chain, and marketplace platforms.", "🌱")
        };

        _teamMembers = new List<TeamMember>
        {
            new(1, "Tasnim Haque", "Enterprise Architect", "Guides platform strategy, scalability, and integration patterns for regulated industries.", ""),
            new(2, "Imran Siddique", "Principal Product Designer", "Shapes customer journeys and design systems for mission-critical apps.", ""),
            new(3, "Sadia Rahman", "Staff Software Engineer", "Leads cloud-native development and continuous delivery initiatives.", ""),
            new(4, "Rafiul Karim", "Data Platform Lead", "Builds analytics foundations that turn operational data into reliable insights.", "")
        };

        _whyChooseUs = new List<WhyChooseUsItem>
        {
            new("Professional developers", "Only senior engineers with proven delivery experience join our pods.", "👩‍💻"),
            new("Dedicated account specialists", "Client partners ensure proactive communication and remove blockers.", "🎯"),
            new("Flexible strategy", "Engagements adapt from discovery to scale without losing momentum.", "🧭"),
            new("On-time delivery", "Transparent reporting and automation keep launches on track.", "⏱️")
        };

        _trustedBy = new TrustedBySection(
            "Trusted by 50+ companies",
            "Product leaders across North America, Europe, and APAC rely on VivaSphere engineers to ship resilient platforms.",
            new[]
            {
                "Trident Finserve",
                "SummitPay",
                "Orbit Logistics",
                "Pulse Health",
                "Skyline Media",
                "Northwind",
                "NovaRetail",
                "MetroTel",
                "BrightBank",
                "FleetWave"
            }
        );

        _techStackSection = new TechStackSection(
            "We work across modern tech stacks",
            "From cloud-native platforms to immersive front-ends, we assemble teams fluent in the tools that keep you competitive.",
            _techStack
        );

        _testimonialSection = new TestimonialSection(
            "50+ brands count on us",
            "Partnerships that compound value",
            "Our clients see VivaSphere as a proactive offshore partner that delivers measurable business outcomes.",
            "Rated 4.9/5 on Clutch",
            _testimonials
        );

        _industrySection = new IndustrySection(
            "Industry expertise",
            "Domain specialists for complex environments",
            "We pair industry insight with engineering rigor to design software that respects regulatory and operational nuance.",
            _industries
        );

        _processSection = new ProcessSection(
            "How we get you moving",
            "Our process is simple, smooth, and efficient",
            "A collaborative rhythm keeps everyone aligned on outcomes while preserving transparency at every step.",
            new List<ProcessStep>
            {
                new(1, "Strategy session", "Align on business goals, current architecture, and desired outcomes."),
                new(2, "Shape your team", "Select curated experts and agree on rituals, tooling, and governance."),
                new(3, "Execute & iterate", "Ship increments with clear metrics, demos, and asynchronous updates."),
                new(4, "Scale & support", "Optimize performance, plan future initiatives, and transition knowledge.")
            },
            new ProcessCallToAction("Schedule a Call", "https://calendly.com/vivasphere/intro-call")
        );

        _excellence = new ExcellenceShowcase(
            "Excellence is our standard",
            "Recognized by global platforms",
            "Independent reviewers and industry bodies acknowledge our craft, security posture, and client satisfaction.",
            new List<AwardBadge>
            {
                new("Clutch Top B2B Company", "Awarded for consistent 5-star client reviews.", "", "https://clutch.co"),
                new("GoodFirms Leader", "Recognized for software development excellence.", "", "https://goodfirms.co"),
                new("DesignRush Partner", "Highlighted for product design and UX innovation.", "", "https://designrush.com"),
                new("Microsoft Partner", "Certified expertise across Azure cloud services.", "", "https://partner.microsoft.com"),
                new("AWS Select Partner", "Validated delivery of secure, scalable cloud workloads.", "", "https://aws.amazon.com/partners")
            }
        );

        _finalCta = new FinalCtaContent(
            "Let’s build together",
            "Accelerate your software roadmap with VivaSphere",
            "Tell us about your ambitions and we’ll assemble a dedicated squad ready to deliver in less than two weeks.",
            "Hire a Team",
            "/contact",
            "See Company Profile",
            "/about",
            ""
        );

        _faqs = new List<FaqItem>
        {
            new(1, "Why is VivaSphere considered among the best engineering partners in Bangladesh?",
                "We pair senior engineers, designers, and product leaders who have shipped regulated platforms across four continents.",
                "Our blended delivery model combines local leadership with global quality standards so you gain strategic partners, not contractors.",
                "Reputation"),
            new(2, "How much does custom software development usually cost?",
                "Most discovery-to-launch engagements fall between $60k and $250k depending on scope, compliance requirements, and integration complexity.",
                "We co-create a delivery roadmap, define milestones, and provide transparent burn reports so you always know how investment maps to outcomes.",
                "Budget"),
            new(3, "What advantages come from outsourcing to Bangladesh?",
                "Bangladesh offers a deep talent pool of English-proficient engineers with overlapping hours for Europe and North America.",
                "Our operations hubs in Dhaka and Rajshahi deliver competitive pricing while maintaining rigorous security and compliance practices.",
                "Outsourcing"),
            new(4, "Which technologies do you use and how do you choose them?",
                "We support modern stacks across cloud, web, mobile, and data including .NET, Go, Node.js, React, Flutter, Azure, AWS, and Snowflake.",
                "Architecture decisions are driven by business goals, scalability targets, and your existing ecosystem to reduce future maintenance.",
                "Technology"),
            new(5, "How do you manage quality and communication?",
                "Automated testing, code reviews, observability dashboards, and definition-of-done checklists are built into every engagement.",
                "Weekly steering syncs, daily stand-ups, and written status reports keep stakeholders aligned regardless of time zone.",
                "Delivery")
        };

        _blogPosts = new List<BlogPost>
        {
            new(1, "scaling-observability", "Scaling observability across distributed platforms", "A playbook for modernizing monitoring with open telemetry.",
                "We share our approach to instrumenting polyglot services using OpenTelemetry, central logging, and SRE scorecards.", "Cloud", DateTime.UtcNow.AddDays(-12), "", "VivaSphere Engineering Team", "8 min read"),
            new(2, "bangladesh-engineering-talent", "Building global products from Bangladesh", "How distributed Bangladeshi teams deliver enterprise-grade software.",
                "Insights from working with clients across four continents and establishing co-located pods for complex programs.", ".NET", DateTime.UtcNow.AddDays(-30), "", "Ayesha Rahman", "6 min read"),
            new(3, "ux-for-fintech", "Designing trust in fintech onboarding", "Patterns that simplify compliance without hurting conversions.",
                "Explore UX strategies that balance compliance, identity verification, and delightful onboarding for financial apps.", "AI", DateTime.UtcNow.AddDays(-45), "", "Imran Siddique", "7 min read")
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
            "Custom software development partner",
            "Bangladesh’s product squads for global innovators",
            "Deploy agile teams from Dhaka and Rajshahi that design, build, and scale dependable software for ambitious companies.",
            "Hire a Dedicated Team",
            "See Company Profile",
            new[]
            {
                new StatItem("Specialists onboard", "50+"),
                new StatItem("Products delivered", "100+"),
                new StatItem("Years of partnership", "10+"),
                new StatItem("Tech stacks mastered", "20+")
            },
            ""
        ),
        _trustedBy,
        _collaborationModels,
        _services,
        _products,
        _productSpotlights,
        _techStackSection,
        _testimonialSection,
        _industrySection,
        _excellence,
        _whyChooseUs,
        _teamMembers,
        _processSection,
        _faqs,
        _blogPosts.Take(3).ToList(),
        _finalCta
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

    private static ComparisonTable BuildComparison(string serviceName, string serviceFocus) => new(
        new[] { serviceName, "MVP Development", "Project Delivery" },
        new[]
        {
            new ComparisonRow("Access to top talent", new[]
            {
                $"Curated experts in {serviceFocus}",
                "Cross-functional squad for core product validation",
                "Multidisciplinary pod owning the full roadmap"
            }),
            new ComparisonRow("Ability to customize", new[]
            {
                "Scale roles up or down to match sprint scope",
                "Fixed core team aligned to MVP milestones",
                "Team structure set to manage long-term delivery"
            }),
            new ComparisonRow("Speed to scale", new[]
            {
                "Kickoff in 1-2 weeks",
                "Discovery and launch in ~12 weeks",
                "Structured to deliver continuous releases"
            }),
            new ComparisonRow("Full product development", new[]
            {
                "You lead roadmap while we supply execution",
                "Focused on validating the critical feature set",
                "Owns backlog, releases, and post-launch ops"
            }),
            new ComparisonRow("Cost effectiveness", new[]
            {
                "Pay only for specialists you embed",
                "Budget optimized for early market validation",
                "Investment aligned to enterprise-scale programs"
            })
        }
    );

    private static IReadOnlyList<ServiceProcessStep> BuildProcess(
        string discovery,
        string selection,
        string delivery,
        string evolve
    ) => new List<ServiceProcessStep>
    {
        new(1, "Define the mission", discovery),
        new(2, "Assemble the squad", selection),
        new(3, "Deliver with transparency", delivery),
        new(4, "Evolve and scale", evolve)
    };
}
