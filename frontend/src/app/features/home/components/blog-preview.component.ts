import { CommonModule, DatePipe } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BlogPost } from '../../../shared/models/content.models';

@Component({
  selector: 'app-blog-preview',
  standalone: true,
  imports: [CommonModule, RouterModule, DatePipe],
  templateUrl: './blog-preview.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class BlogPreviewComponent {
  @Input({ required: true }) posts: BlogPost[] = [];
}
