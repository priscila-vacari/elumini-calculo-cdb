import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalculoComponent } from './components/calculo/calculo.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [CommonModule, CalculoComponent]
})

export class AppComponent {
  title = 'calculo-cdb';
}
