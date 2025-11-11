import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, computed } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  standalone: true,
  selector: 'app-mvp-calculator',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './mvp-calculator.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class MvpCalculatorComponent {
  private readonly fb = new FormBuilder();

  readonly form = this.fb.nonNullable.group({
    productType: ['', Validators.required],
    platforms: this.fb.nonNullable.control('web'),
    teamSize: this.fb.nonNullable.control(4, Validators.required),
    duration: this.fb.nonNullable.control(3, Validators.required),
    complexity: this.fb.nonNullable.control('standard', Validators.required)
  });

  readonly estimate = computed(() => {
    const values = this.form.getRawValue();
    const baseRate = values.complexity === 'advanced' ? 12000 : values.complexity === 'enterprise' ? 18000 : 8000;
    const multiplier = values.platforms === 'both' ? 1.4 : values.platforms === 'mobile' ? 1.2 : 1;
    const teamFactor = values.teamSize / 4;
    const duration = values.duration;
    const lower = baseRate * multiplier * teamFactor * duration;
    const upper = lower * 1.35;
    return { lower: Math.round(lower), upper: Math.round(upper) };
  });
}
