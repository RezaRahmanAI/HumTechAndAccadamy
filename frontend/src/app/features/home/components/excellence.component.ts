import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

@Component({
  selector: 'app-excellence',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './excellence.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ExcellenceComponent {
  @Input({ required: true }) items: Array<{ title: string; description: string; icon: string }> = [];
}
