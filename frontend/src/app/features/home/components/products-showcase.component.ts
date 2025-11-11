import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProductCaseStudy } from '../../../shared/models/content.models';

@Component({
  selector: 'app-products-showcase',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './products-showcase.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProductsShowcaseComponent {
  @Input({ required: true }) products: ProductCaseStudy[] = [];
}
