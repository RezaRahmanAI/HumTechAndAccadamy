import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { FaqItem } from '../../../shared/models/content.models';

@Component({
  selector: 'app-faq-accordion',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './faq-accordion.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class FaqAccordionComponent {
  @Input({ required: true }) items: FaqItem[] = [];
  openId?: number;

  toggle(id: number): void {
    this.openId = this.openId === id ? undefined : id;
  }
}
