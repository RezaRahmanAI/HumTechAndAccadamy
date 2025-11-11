import { AsyncPipe, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { HomeContent } from '../../shared/models/content.models';
import { HeroComponent } from './components/hero.component';
import { TrustedByComponent } from './components/trusted-by.component';
import { CollaborationModelsComponent } from './components/collaboration-models.component';
import { ServicesGridComponent } from './components/services-grid.component';
import { ProductsShowcaseComponent } from './components/products-showcase.component';
import { TechStackMarqueeComponent } from './components/tech-stack-marquee.component';
import { TestimonialsComponent } from './components/testimonials.component';
import { IndustriesGridComponent } from './components/industries-grid.component';
import { ExcellenceComponent } from './components/excellence.component';
import { ProcessTimelineComponent } from './components/process-timeline.component';
import { FaqAccordionComponent } from './components/faq-accordion.component';
import { FinalCtaComponent } from './components/final-cta.component';

@Component({
  standalone: true,
  imports: [
    AsyncPipe,
    NgIf,
    HeroComponent,
    TrustedByComponent,
    CollaborationModelsComponent,
    ServicesGridComponent,
    ProductsShowcaseComponent,
    TechStackMarqueeComponent,
    TestimonialsComponent,
    IndustriesGridComponent,
    ExcellenceComponent,
    ProcessTimelineComponent,
    FaqAccordionComponent,
    FinalCtaComponent
  ],
  templateUrl: './home.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent {
  private readonly contentService = inject(ContentService);
  loading = true;
  readonly content$: Observable<HomeContent> = this.contentService.getHome().pipe(
    finalize(() => {
      this.loading = false;
    })
  );
}
