import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

@Component({
  selector: 'app-process-timeline',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './process-timeline.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProcessTimelineComponent {
  @Input({ required: true }) steps: Array<{ step: number; title: string; description: string }> = [];
}
