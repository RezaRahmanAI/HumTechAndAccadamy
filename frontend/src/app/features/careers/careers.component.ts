import { AsyncPipe, NgFor } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { JobPosting } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-careers',
  imports: [NgFor, AsyncPipe, RouterModule],
  templateUrl: './careers.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CareersComponent {
  private readonly contentService = inject(ContentService);
  readonly jobs$: Observable<JobPosting[]> = this.contentService.getCareers();
}
