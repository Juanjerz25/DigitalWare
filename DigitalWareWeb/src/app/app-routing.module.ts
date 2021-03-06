import { DxButtonModule } from 'devextreme-angular/ui/button';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent, UserPanelComponent, UserPanelModule } from './shared/components';
import { AuthGuardService } from './shared/services';
import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';
import { DxDataGridModule, DxFormModule, DxPopupModule, DxSelectBoxModule, DxTemplateModule } from 'devextreme-angular';
import { FacturacionComponent } from './pages/facturacion/facturacion.component';
import { HttpService } from './shared/services/http.service';
import { ProductoComponent } from './pages/producto/producto.component';
import { ClienteComponent } from './pages/cliente/cliente.component';
import { AgregarFacturaComponent, AgregarFacturaModule } from './shared/components/agregar-factura/agregar-factura.component';
import { AgregarFacturaProductoModule } from './shared/components/agregar-factura-producto/agregar-factura-producto.component';

const routes: Routes = [
  {
    path: 'tasks',
    component: TasksComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'facturacion',
    component: FacturacionComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'producto',
    component: ProductoComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'cliente',
    component: ClienteComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'home',
    component: HomeComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'login-form',
    component: LoginFormComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'reset-password',
    component: ResetPasswordFormComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'create-account',
    component: CreateAccountFormComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: 'change-password/:recoveryCode',
    component: ChangePasswordFormComponent,
    canActivate: [AuthGuardService]
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];

const vistas = [AgregarFacturaModule,
  AgregarFacturaProductoModule]
@NgModule({
  imports: [...vistas,
  RouterModule.forRoot(routes),
    DxDataGridModule,
    DxFormModule,
    DxButtonModule,
    DxPopupModule,
    DxTemplateModule,
    DxSelectBoxModule],
  providers: [AuthGuardService],
  exports: [RouterModule],
  declarations: [HomeComponent, ProfileComponent, TasksComponent, FacturacionComponent, ProductoComponent, ClienteComponent]
})
export class AppRoutingModule { }
