import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { SidebarComponent } from './components/reusable/sidebar/sidebar.component';
import { AuthenticatedLayoutComponent } from './components/auth/authenticated-layout/authenticated-layout.component';


@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    AuthenticatedLayoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
