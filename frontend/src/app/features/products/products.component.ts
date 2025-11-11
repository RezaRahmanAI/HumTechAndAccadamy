import { AsyncPipe, NgFor } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { ProductCaseStudy } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-products',
  imports: [NgFor, AsyncPipe, RouterModule],
  templateUrl: './products.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProductsComponent {
  private readonly contentService = inject(ContentService);
  readonly products$: Observable<ProductCaseStudy[]> = this.contentService.getProducts();
}
