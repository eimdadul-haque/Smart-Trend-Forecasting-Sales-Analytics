import { Component, ViewChild } from '@angular/core';
import { SidebarComponent } from './components/reusable/sidebar/sidebar.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.scss'
})
export class AppComponent {
  @ViewChild(SidebarComponent) sidebar!: SidebarComponent;
  
  // Optional: Toggle sidebar from other components
  toggleSidebar() {
    this.sidebar.toggleCollapse();
  }
}
