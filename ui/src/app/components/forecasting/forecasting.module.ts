import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ForecastingRoutingModule } from './forecasting-routing.module';
import { ForecastingComponent } from './forecasting/forecasting.component';


@NgModule({
  declarations: [
    ForecastingComponent
  ],
  imports: [
    CommonModule,
    ForecastingRoutingModule
  ]
})
export class ForecastingModule { }
