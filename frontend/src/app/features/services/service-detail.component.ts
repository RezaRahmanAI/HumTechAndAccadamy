import { AsyncPipe, NgFor, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { map, switchMap, tap } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { ContentService } from '../../core/services/content.service';
import { Service } from '../../shared/models/content.models';

@Component({
  standalone: true,
  selector: 'app-service-detail',
  imports: [NgFor, NgIf, AsyncPipe, RouterModule, ReactiveFormsModule],
  templateUrl: './service-detail.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ServiceDetailComponent {
  private readonly route = inject(ActivatedRoute);
  private readonly contentService = inject(ContentService);
  private readonly fb = inject(FormBuilder);

  submitting = false;
  submitted = false;

  readonly form = this.fb.group({
    name: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    company: [''],
    message: ['', Validators.required]
  });

  readonly service$: Observable<Service> = this.route.paramMap.pipe(
    map((params) => params.get('slug') ?? ''),
    switchMap((slug) => this.contentService.getService(slug))
  );

  submit(service: Service): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }
    this.submitting = true;
    this.contentService
      .submitContact({
        name: this.form.value.name ?? '',
        email: this.form.value.email ?? '',
        company: this.form.value.company ?? '',
        budgetRange: `${service.title} inquiry`,
        message: this.form.value.message ?? ''
      })
      .pipe(tap(() => (this.submitted = true)))
      .subscribe({
        next: () => {
          this.submitting = false;
          this.form.reset();
        },
        error: () => {
          this.submitting = false;
        }
      });
  }
}
