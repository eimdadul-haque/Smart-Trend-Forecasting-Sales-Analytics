import { Component, ViewChild } from '@angular/core';
import { SidebarComponent } from '../../reusable/sidebar/sidebar.component';

@Component({
  selector: 'app-authenticated-layout',
  standalone: false,
  templateUrl: './authenticated-layout.component.html',
  styleUrl: './authenticated-layout.component.scss'
})
export class AuthenticatedLayoutComponent {
  @ViewChild(SidebarComponent) sidebar!: SidebarComponent;
  
  constructor() {}
  
  toggleSidebar() {
    this.sidebar.toggleCollapse();
  }
}
