import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../../services/auth.service';
import { Router } from '@angular/router';

interface MenuItem {
  title: string;
  icon: string;
  route?: string;
  children?: MenuItem[];
  isExpanded?: boolean;
}

@Component({
  selector: 'app-sidebar',
  standalone: false,
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss'
})
export class SidebarComponent implements OnInit {
  isCollapsed = false;
  isMobileView = false;

  menuItems: MenuItem[] = [
    {
      title: 'Dashboard',
      icon: 'bi-speedometer2',
      route: '/dashboard'
    },
    {
      title: 'Products',
      icon: 'bi-box-seam',
      children: [
        { title: 'All Products', route: '/products', icon: '' },
        { title: 'Add New', route: '/products/new', icon: '' },
      ]
    },
    {
      title: 'Orders',
      icon: 'bi-cart',
      route: '/orders'
    },
    {
      title: 'Customers',
      icon: 'bi-people',
      route: '/customers'
    },
    {
      title: 'Reports',
      icon: 'bi-graph-up',
      children: [
        { title: 'Sales', route: '/reports/sales', icon: '' },
        { title: 'Inventory', route: '/reports/inventory', icon: '' }
      ]
    },
    {
      title: 'Settings',
      icon: 'bi-gear',
      route: '/settings'
    }
  ];

  constructor(
    public authService: AuthService,
    private router: Router
  ) {}

  ngOnInit() {
    this.checkViewport();
    window.addEventListener('resize', () => this.checkViewport());
  }

  checkViewport() {
    this.isMobileView = window.innerWidth < 992;
    if (this.isMobileView) {
      this.isCollapsed = true;
    }
  }

  toggleCollapse() {
    this.isCollapsed = !this.isCollapsed;
  }

  toggleSubMenu(menuItem: MenuItem) {
    if (menuItem.children) {
      menuItem.isExpanded = !menuItem.isExpanded;
    } else if (menuItem.route) {
      this.router.navigate([menuItem.route]);
    }
  }

  isActive(route: string | undefined): boolean {
    return route ? this.router.isActive(route, false) : false;
  }

  hasActiveChild(menuItem: MenuItem): boolean {
    if (!menuItem.children) return false;
    
    return menuItem.children.some(child => {
      if (child.route) {
        return this.router.isActive(child.route, false);
      }
      return false;
    });
  }
}
