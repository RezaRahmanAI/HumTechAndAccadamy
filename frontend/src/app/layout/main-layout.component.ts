import { AsyncPipe, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import {
  RouterOutlet,
  Router,
  NavigationStart,
  NavigationEnd,
  NavigationCancel,
  NavigationError
} from '@angular/router';
import { filter, map, startWith } from 'rxjs/operators';
import { Observable, merge } from 'rxjs';
import { NavbarComponent } from './components/navbar.component';
import { FooterComponent } from './components/footer.component';

@Component({
  selector: 'app-main-layout',
  standalone: true,
  imports: [RouterOutlet, NavbarComponent, FooterComponent, AsyncPipe, NgIf],
  template: `
    <div class="flex min-h-screen flex-col bg-slate-50 text-slate-900">
      <app-navbar></app-navbar>
      <div class="h-1 w-full bg-gradient-to-r from-sky-400 to-blue-600" *ngIf="isLoading$ | async"></div>
      <main class="flex-1">
        <router-outlet></router-outlet>
      </main>
      <app-footer></app-footer>
    </div>
  `,
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class MainLayoutComponent {
  private router = inject(Router);
  readonly isLoading$: Observable<boolean> = merge(
    this.router.events.pipe(
      filter((event) => event instanceof NavigationStart),
      map(() => true)
    ),
    this.router.events.pipe(
      filter(
        (event) => event instanceof NavigationEnd || event instanceof NavigationCancel || event instanceof NavigationError
      ),
      map(() => false)
    )
  ).pipe(startWith(false));
}
