import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-resultado',
  templateUrl: './resultado.component.html',
  styleUrls: ['./resultado.component.css'],
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule] 
})
export class ResultadoComponent {
  @Input() dados!: { valorBruto: number, valorLiquido: number };
}
