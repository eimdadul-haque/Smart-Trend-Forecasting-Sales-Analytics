import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../../authGuard/AuthGuard';

const routes: Routes = [
  {
    path: 'visual',
    loadChildren: () => import('../visual/visual.module').then(m => m.VisualModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'forecasting',
    loadChildren: () => import('../forecasting/forecasting.module').then(m => m.ForecastingModule),
    canActivate: [AuthGuard]
  },
  {
    path: '  sales-record',
    loadChildren: () => import('../sales-record/sales-record.module').then(m => m.SalesRecordModule),
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutsRoutingModule { }
