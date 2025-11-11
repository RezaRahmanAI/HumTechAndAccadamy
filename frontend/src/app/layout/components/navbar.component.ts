import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, HostListener, inject } from '@angular/core';
import { RouterModule } from '@angular/router';

interface NavItem {
  label: string;
  path?: string;
  external?: boolean;
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
    { label: 'Technologies', path: '/about' },
    {
      label: 'For Hiring',
      children: [
        { label: 'Hire Developers', path: '/services/team-augmentation' },
        { label: 'JavaScript Experts', path: '/services/js-experts' },
        { label: 'Python Engineers', path: '/services/python-experts' },
        { label: 'Cloud Architects', path: '/services/cloud-architects' }
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
  }

  @HostListener('window:scroll')
  onScroll(): void {}
}
