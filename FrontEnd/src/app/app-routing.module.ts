import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { InvoiceListComponent } from './invoice-list/invoice-list.component';
import { InvoiceComponent } from './invoice-add/invoice-add.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'invoice-list', component: InvoiceListComponent },
  { path: 'invoice-add', component: InvoiceComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' } // Ana sayfa olarak login sayfasını yönlendiriyoruz
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
