import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {
  BlogPost,
  CollaborationModel,
  FaqItem,
  HomeContent,
  JobPosting,
  ProductCaseStudy,
  Service,
  Testimonial
} from '../../shared/models/content.models';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class ContentService {
  private readonly http = inject(HttpClient);
  private readonly apiBase = environment.apiBaseUrl;

  getHome(): Observable<HomeContent> {
    return this.http.get<HomeContent>(`${this.apiBase}/home`);
  }

  getServices(): Observable<Service[]> {
    return this.http.get<Service[]>(`${this.apiBase}/services`);
  }

  getService(slug: string): Observable<Service> {
    return this.http.get<Service>(`${this.apiBase}/services/${slug}`);
  }

  getProducts(): Observable<ProductCaseStudy[]> {
    return this.http.get<ProductCaseStudy[]>(`${this.apiBase}/products`);
  }

  getProduct(slug: string): Observable<ProductCaseStudy> {
    return this.http.get<ProductCaseStudy>(`${this.apiBase}/products/${slug}`);
  }

  getBlogPosts(): Observable<BlogPost[]> {
    return this.http.get<BlogPost[]>(`${this.apiBase}/blog`);
  }

  getBlogPost(slug: string): Observable<BlogPost> {
    return this.http.get<BlogPost>(`${this.apiBase}/blog/${slug}`);
  }

  getTestimonials(): Observable<Testimonial[]> {
    return this.http.get<Testimonial[]>(`${this.apiBase}/testimonials`);
  }

  getFaq(): Observable<FaqItem[]> {
    return this.http.get<FaqItem[]>(`${this.apiBase}/faq`);
  }

  getCareers(): Observable<JobPosting[]> {
    return this.http.get<JobPosting[]>(`${this.apiBase}/careers`);
  }

  getCareer(slug: string): Observable<JobPosting> {
    return this.http.get<JobPosting>(`${this.apiBase}/careers/${slug}`);
  }

  submitContact(payload: { name: string; email: string; company: string; budgetRange: string; message: string }): Observable<void> {
    return this.http.post<void>(`${this.apiBase}/contact`, payload);
  }
}
