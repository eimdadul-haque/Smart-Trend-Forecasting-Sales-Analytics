import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '../../authGuard/AuthGuard';

const routes: Routes = [
    {
    path: 'visual',
    loadChildren: () => import('../visual/visual.module').then(m => m.VisualModule),
    canActivate: [AuthGuard]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutsRoutingModule { }
