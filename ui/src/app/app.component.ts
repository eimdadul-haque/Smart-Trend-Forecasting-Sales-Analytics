import { Component, ViewChild } from '@angular/core';
import { SidebarComponent } from './components/reusable/sidebar/sidebar.component';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.scss'
})
export class AppComponent {
  constructor(
    public authService: AuthService
  ) { }
}
