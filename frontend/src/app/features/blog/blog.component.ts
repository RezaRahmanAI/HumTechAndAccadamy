import { AsyncPipe, NgFor, NgClass } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { BlogPost } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-blog',
  imports: [NgFor, AsyncPipe, RouterModule, NgClass],
  templateUrl: './blog.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class BlogComponent {
  private readonly contentService = inject(ContentService);
  readonly posts$: Observable<BlogPost[]> = this.contentService.getBlogPosts();
  readonly categories = ['All', '.NET', 'JavaScript', 'AI', 'Cloud'];
  selected = 'All';

  filter(posts: BlogPost[]): BlogPost[] {
    if (this.selected === 'All') {
      return posts;
    }
    return posts.filter((post) => post.category === this.selected);
  }
}
