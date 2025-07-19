import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './authGuard/AuthGuard';
import { AdminLayoutComponent } from './components/layouts/admin-layout/admin-layout.component';

const routes: Routes = [
  // {
  //   path: '',
  //   loadChildren: () => import('./components/home/home.module').then(m => m.HomeModule),
  //   pathMatch: 'full'
  // },
  {
    path: 'auth',
    loadChildren: () => import('./components/auth/auth.module').then(m => m.AuthModule)
  },
  // {
  //   path: 'visual',
  //   loadChildren: () => import('./components/visual/visual.module').then(m => m.VisualModule),
  //   canActivate: [AuthGuard]
  // },
  {
    path: '',
    component: AdminLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: () => import('./components/layouts/layouts.module').then(x => x.LayoutsModule)
    }
  ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
