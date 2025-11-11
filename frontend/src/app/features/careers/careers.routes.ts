import { Routes } from '@angular/router';

export const CAREER_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./careers.component').then((m) => m.CareersComponent)
  },
  {
    path: ':slug',
    loadComponent: () => import('./career-detail.component').then((m) => m.CareerDetailComponent)
  }
];
