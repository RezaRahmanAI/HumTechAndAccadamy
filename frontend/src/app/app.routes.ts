import { Routes } from '@angular/router';
import { MainLayoutComponent } from './layout/main-layout.component';

export const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      {
        path: '',
        loadComponent: () => import('./features/home/home.component').then((m) => m.HomeComponent)
      },
      {
        path: 'services',
        loadChildren: () => import('./features/services/services.routes').then((m) => m.SERVICES_ROUTES)
      },
      {
        path: 'products',
        loadChildren: () => import('./features/products/products.routes').then((m) => m.PRODUCT_ROUTES)
      },
      {
        path: 'blog',
        loadChildren: () => import('./features/blog/blog.routes').then((m) => m.BLOG_ROUTES)
      },
      {
        path: 'career',
        loadChildren: () => import('./features/careers/careers.routes').then((m) => m.CAREER_ROUTES)
      },
      {
        path: 'about',
        loadComponent: () => import('./features/about/about.component').then((m) => m.AboutComponent)
      },
      {
        path: 'contact',
        loadComponent: () => import('./features/contact/contact.component').then((m) => m.ContactComponent)
      },
      {
        path: 'mvp-calculator',
        loadComponent: () => import('./features/mvp-calculator/mvp-calculator.component').then((m) => m.MvpCalculatorComponent)
      }
    ]
  },
  { path: '**', redirectTo: '' }
];
