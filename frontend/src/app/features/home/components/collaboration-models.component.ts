import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { CollaborationModel } from '../../../shared/models/content.models';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-collaboration-models',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './collaboration-models.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CollaborationModelsComponent {
  @Input({ required: true }) models: CollaborationModel[] = [];

  toSlug(name: string): string {
    return name
      .toLowerCase()
      .replace(/[^a-z0-9]+/g, '-')
      .replace(/(^-|-$)/g, '');
  }
}
