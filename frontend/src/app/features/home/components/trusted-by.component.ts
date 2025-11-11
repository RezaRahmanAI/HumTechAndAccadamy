import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

@Component({
  selector: 'app-trusted-by',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './trusted-by.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TrustedByComponent {
  @Input({ required: true }) logos: string[] = [];
}
