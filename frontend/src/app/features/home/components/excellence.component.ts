import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { ExcellenceShowcase } from '../../../shared/models/content.models';

@Component({
  selector: 'app-excellence',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './excellence.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ExcellenceComponent {
  @Input({ required: true }) section!: ExcellenceShowcase;
}
