import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { TechStackSection } from '../../../shared/models/content.models';

@Component({
  selector: 'app-tech-stack-marquee',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tech-stack-marquee.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TechStackMarqueeComponent {
  @Input({ required: true }) section!: TechStackSection;
}
