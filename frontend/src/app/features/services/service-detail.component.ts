import { AsyncPipe, NgFor, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { map, switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { Service } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-service-detail',
  imports: [NgFor, NgIf, AsyncPipe, RouterModule],
  templateUrl: './service-detail.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ServiceDetailComponent {
  private readonly route = inject(ActivatedRoute);
  private readonly contentService = inject(ContentService);

  readonly service$: Observable<Service> = this.route.paramMap.pipe(
    map((params) => params.get('slug') ?? ''),
    switchMap((slug) => this.contentService.getService(slug))
  );
}
