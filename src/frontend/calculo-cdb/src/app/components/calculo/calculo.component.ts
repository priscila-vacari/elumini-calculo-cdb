import { Component } from '@angular/core';
import { CdbService } from '../../services/cdb.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-calculo',
  templateUrl: './calculo.component.html',
  styleUrls: ['./calculo.component.css'],
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule]  
})
export class CalculoComponent {
  valorInicial!: number;
  prazoMeses!: number;
  resultado!: any;

  constructor(private cdbService: CdbService) {}

  calcularInvestimento() {
    const request = { valorInicial: this.valorInicial, prazoMeses: this.prazoMeses };
    
    this.cdbService.calcularCdb(request).subscribe({
      next: (response) => {
        this.resultado = response;
      },
      error: (err) => {
        switch (err.status) {
          case 400:
            alert('⚠️ Requisição inválida. Verifique os dados informados.');
            break;
          default:
            alert('❌ Erro inesperado. Tente novamente mais tarde.');
            console.error('Erro:', err);
        }
      }
    });
  }
}
