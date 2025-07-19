import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LayoutsRoutingModule } from './layouts-routing.module';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import { SidebarComponent } from '../reusable/sidebar/sidebar.component';


@NgModule({
  declarations: [
    AdminLayoutComponent,
    SidebarComponent
  ],
  imports: [
    CommonModule,
    LayoutsRoutingModule
  ]
})
export class LayoutsModule { }
