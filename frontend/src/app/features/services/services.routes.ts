import { Routes } from '@angular/router';

export const SERVICES_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./services.component').then((m) => m.ServicesComponent)
  },
  {
    path: ':slug',
    loadComponent: () => import('./service-detail.component').then((m) => m.ServiceDetailComponent)
  }
];
