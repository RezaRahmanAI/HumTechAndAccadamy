import { AsyncPipe, NgFor, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { map, switchMap } from 'rxjs/operators';
import { ContentService } from '../../core/services/content.service';
import { ProductCaseStudy } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-product-detail',
  imports: [NgFor, NgIf, AsyncPipe, RouterModule],
  templateUrl: './product-detail.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProductDetailComponent {
  private readonly route = inject(ActivatedRoute);
  private readonly contentService = inject(ContentService);

  readonly product$: Observable<ProductCaseStudy> = this.route.paramMap.pipe(
    map((params) => params.get('slug') ?? ''),
    switchMap((slug) => this.contentService.getProduct(slug))
  );
}
