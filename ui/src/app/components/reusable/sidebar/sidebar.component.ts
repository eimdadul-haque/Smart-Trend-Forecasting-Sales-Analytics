import { Component, OnInit } from '@angular/core';


export interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}

export const ROUTES: RouteInfo[] = [
    { path: 'visual/dashboard', title: 'Dashboard', icon:'nc-bank', class: '' },
    { path: 'forecasting', title: 'Forecasting', icon:'nc-bank', class: '' },
];
@Component({
  selector: 'app-sidebar',
  standalone: false,
  //moduleId: module.id,
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss'
})

export class SidebarComponent implements OnInit {
    public menuItems: any[] = [];
    ngOnInit() {
        this.menuItems = ROUTES.filter(menuItem => menuItem);
    }
}

