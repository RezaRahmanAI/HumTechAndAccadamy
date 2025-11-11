import { AsyncPipe, NgFor, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { Service } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-services',
  imports: [NgFor, NgIf, AsyncPipe, RouterModule],
  templateUrl: './services.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ServicesComponent {
  private readonly contentService = inject(ContentService);
  readonly services$: Observable<Service[]> = this.contentService.getServices();
}
