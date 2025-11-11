import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Service } from '../../../shared/models/content.models';

@Component({
  selector: 'app-services-grid',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './services-grid.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ServicesGridComponent {
  @Input({ required: true }) services: Service[] = [];
}
