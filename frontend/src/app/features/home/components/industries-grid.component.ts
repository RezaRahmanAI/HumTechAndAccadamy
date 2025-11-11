import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { IndustrySection } from '../../../shared/models/content.models';

@Component({
  selector: 'app-industries-grid',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './industries-grid.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class IndustriesGridComponent {
  @Input({ required: true }) section!: IndustrySection;
}
