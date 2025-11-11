import { AsyncPipe, DatePipe, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { map, switchMap } from 'rxjs/operators';
import { ContentService } from '../../core/services/content.service';
import { BlogPost } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-blog-detail',
  imports: [NgIf, AsyncPipe, RouterModule, DatePipe],
  templateUrl: './blog-detail.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class BlogDetailComponent {
  private readonly route = inject(ActivatedRoute);
  private readonly contentService = inject(ContentService);

  readonly post$: Observable<BlogPost> = this.route.paramMap.pipe(
    map((params) => params.get('slug') ?? ''),
    switchMap((slug) => this.contentService.getBlogPost(slug))
  );
}
