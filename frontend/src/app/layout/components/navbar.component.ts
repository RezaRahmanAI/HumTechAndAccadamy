import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, HostListener, inject } from '@angular/core';
import { RouterModule } from '@angular/router';

interface NavItem {
  label: string;
  path?: string;
  external?: boolean;
  fragment?: string;
  children?: NavItem[];
}

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule],
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  isMobileMenuOpen = false;
  isServicesOpen = false;
  isHiringOpen = false;
  mobileServicesOpen = false;
  mobileHiringOpen = false;

  readonly navItems: NavItem[] = [
    {
      label: 'Services',
      children: [
        { label: 'Team Augmentation', path: '/services/team-augmentation' },
        { label: 'End-to-End Development', path: '/services/end-to-end-development' },
        { label: 'MVP Services', path: '/services/mvp-services' },
        { label: 'Offshore Development', path: '/services/offshore-development' }
      ]
    },
    { label: 'Technologies', path: '/', fragment: 'tech-stack' },
    {
      label: 'For Hiring',
      children: [
        { label: 'Hire Developers', path: '/services/team-augmentation' },
        { label: 'Hire JavaScript Developers', path: '/services/mvp-services' },
        { label: 'Hire Python Developers', path: '/services/data-analytics' },
        { label: 'Hire Java Developers', path: '/services/end-to-end-development' },
        { label: 'Hire Golang Developers', path: '/services/cloud-services' },
        { label: 'Hire .NET Developers', path: '/services/team-augmentation' }
      ]
    },
    { label: 'MVP Calculator', path: '/mvp-calculator' },
    { label: 'Academy', path: 'https://example.com/academy', external: true },
    { label: 'Blog', path: '/blog' },
    { label: 'Contact', path: '/contact' }
  ];

  toggleMobileMenu(): void {
    this.isMobileMenuOpen = !this.isMobileMenuOpen;
  }

  closeMobileMenu(): void {
    this.isMobileMenuOpen = false;
    this.mobileServicesOpen = false;
    this.mobileHiringOpen = false;
  }

  toggleMobileSection(section: 'services' | 'hiring'): void {
    if (section === 'services') {
      this.mobileServicesOpen = !this.mobileServicesOpen;
    } else {
      this.mobileHiringOpen = !this.mobileHiringOpen;
    }
  }

  @HostListener('window:scroll')
  onScroll(): void {}
}
