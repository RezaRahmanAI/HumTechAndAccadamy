import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TeamMember } from '../../../shared/models/content.models';

@Component({
  selector: 'app-team-showcase',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './team-showcase.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TeamShowcaseComponent {
  @Input({ required: true }) members: TeamMember[] = [];
}
