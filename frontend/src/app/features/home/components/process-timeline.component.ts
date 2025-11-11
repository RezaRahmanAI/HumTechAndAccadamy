import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { ProcessSection } from '../../../shared/models/content.models';

@Component({
  selector: 'app-process-timeline',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './process-timeline.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProcessTimelineComponent {
  @Input({ required: true }) section!: ProcessSection;
}
