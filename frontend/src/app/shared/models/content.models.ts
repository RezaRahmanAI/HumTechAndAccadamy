export interface Service {
  id: number;
  slug: string;
  title: string;
  subtitle: string;
  description: string;
  icon: string;
  category: string;
  type: string;
  highlights: string[];
  sections: Array<{ heading: string; body: string }>;
  pageContent: ServicePageContent;
}

export interface CollaborationModel {
  id: number;
  name: string;
  shortDescription: string;
  longDescription: string;
  benefits: string[];
  steps: string[];
}

export interface ProductCaseStudy {
  id: number;
  slug: string;
  name: string;
  shortDescription: string;
  longDescription: string;
  techStack: string[];
  industry: string;
  metrics: string[];
  heroImageUrl: string;
}

export interface TechLogo {
  id: number;
  name: string;
  category: string;
  logoUrl: string;
}

export interface Testimonial {
  id: number;
  authorName: string;
  authorRole: string;
  companyName: string;
  quote: string;
  companyLogoUrl: string;
}

export interface Industry {
  id: number;
  name: string;
  description: string;
  icon: string;
}

export interface FaqItem {
  id: number;
  question: string;
  answer: string;
  detail: string;
  category: string;
}

export interface BlogPost {
  id: number;
  slug: string;
  title: string;
  excerpt: string;
  body: string;
  category: string;
  publishedAt: string;
  coverImageUrl: string;
  author: string;
  readTime: string;
}

export interface JobPosting {
  id: number;
  slug: string;
  title: string;
  location: string;
  employmentType: string;
  department: string;
  description: string;
  responsibilities: string[];
  requirements: string[];
  postedAt: string;
}

export interface ContactRequest {
  id?: number;
  name: string;
  email: string;
  company: string;
  budgetRange: string;
  message: string;
  createdAt?: string;
}

export interface HomeContent {
  hero: {
    eyebrow: string;
    title: string;
    description: string;
    primaryCta: string;
    secondaryCta: string;
    stats: Array<{ label: string; value: string }>;
    illustrationUrl: string;
  };
  trustedBy: TrustedBySection;
  collaborationModels: CollaborationModel[];
  services: Service[];
  featuredProducts: ProductCaseStudy[];
  productSpotlights: ProductSpotlight[];
  techStack: TechStackSection;
  testimonials: TestimonialSection;
  industries: IndustrySection;
  excellence: ExcellenceShowcase;
  whyChooseUs: Array<{ title: string; description: string; icon: string }>;
  teamMembers: TeamMember[];
  process: ProcessSection;
  faqs: FaqItem[];
  recentBlogs: BlogPost[];
  finalCta: FinalCtaContent;
}

export interface TrustedBySection {
  eyebrow: string;
  description: string;
  logos: string[];
}

export interface TechStackSection {
  title: string;
  description: string;
  logos: TechLogo[];
}

export interface TestimonialSection {
  eyebrow: string;
  title: string;
  description: string;
  ratingLabel: string;
  items: Testimonial[];
}

export interface IndustrySection {
  eyebrow: string;
  title: string;
  description: string;
  items: Industry[];
}

export interface ExcellenceShowcase {
  eyebrow: string;
  title: string;
  description: string;
  badges: AwardBadge[];
}

export interface AwardBadge {
  name: string;
  description: string;
  logoUrl: string;
  link: string;
}

export interface TeamMember {
  id: number;
  name: string;
  title: string;
  bio: string;
  photoUrl: string;
}

export interface ProcessSection {
  eyebrow: string;
  title: string;
  description: string;
  steps: Array<{ step: number; title: string; description: string }>;
  cta: { label: string; url: string };
}

export interface ProductSpotlight {
  id: number;
  name: string;
  description: string;
  industry: string;
  link: string;
}

export interface FinalCtaContent {
  eyebrow: string;
  title: string;
  description: string;
  primaryCtaLabel: string;
  primaryCtaLink: string;
  secondaryCtaLabel: string;
  secondaryCtaLink: string;
  illustrationUrl: string;
}

export interface ServicePageContent {
  eyebrow: string;
  lead: string;
  primaryCtaLabel: string;
  secondaryCtaLabel: string;
  stats: Array<{ label: string; value: string }>;
  about: Array<{ heading: string; body: string }>;
  benefits: Array<{ title: string; description: string }>;
  comparison: {
    headers: string[];
    rows: Array<{ attribute: string; values: string[] }>;
  };
  process: Array<{ step: number; title: string; description: string }>;
  valueDrivers: string[];
  contact: { title: string; subtitle: string; ctaLabel: string; schedulerUrl: string };
}
