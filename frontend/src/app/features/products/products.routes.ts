import { Routes } from '@angular/router';

export const PRODUCT_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./products.component').then((m) => m.ProductsComponent)
  },
  {
    path: ':slug',
    loadComponent: () => import('./product-detail.component').then((m) => m.ProductDetailComponent)
  }
];
