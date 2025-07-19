import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutsRoutingModule } from './layouts-routing.module';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import { SidebarComponent } from '../reusable/sidebar/sidebar.component';
import { NavbarComponent } from '../reusable/navbar/navbar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AdminLayoutComponent,
    SidebarComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule,
    LayoutsRoutingModule,
    NgbModule
  ]
})
export class LayoutsModule { }
