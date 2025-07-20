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
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutsRoutingModule { }
