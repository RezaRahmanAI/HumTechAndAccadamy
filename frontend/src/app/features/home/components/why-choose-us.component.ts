import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

@Component({
  selector: 'app-why-choose-us',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './why-choose-us.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class WhyChooseUsComponent {
  @Input({ required: true }) items: Array<{ title: string; description: string; icon: string }> = [];
}
