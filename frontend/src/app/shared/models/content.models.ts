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
  trustedBy: string[];
  collaborationModels: CollaborationModel[];
  services: Service[];
  products: ProductCaseStudy[];
  techStack: TechLogo[];
  testimonials: Testimonial[];
  industries: Industry[];
  whyChooseUs: Array<{ title: string; description: string; icon: string }>;
  processSteps: Array<{ step: number; title: string; description: string }>;
  faqs: FaqItem[];
}
