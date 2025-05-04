import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculoComponent } from './components/calculo/calculo.component';
import { ResultadoComponent } from './components/resultado/resultado.component';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

export const routes: Routes = [
    { path: '', redirectTo: 'calculo', pathMatch: 'full' }, 
    { path: 'calculo', component: CalculoComponent },    
    { path: 'resultado', component: ResultadoComponent }
];

@NgModule({
  imports: [FormsModule, CommonModule, HttpClientModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }