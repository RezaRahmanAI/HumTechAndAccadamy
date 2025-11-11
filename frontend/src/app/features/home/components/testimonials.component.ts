import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { Testimonial } from '../../../shared/models/content.models';

@Component({
  selector: 'app-testimonials',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './testimonials.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TestimonialsComponent {
  @Input({ required: true }) testimonials: Testimonial[] = [];
}
