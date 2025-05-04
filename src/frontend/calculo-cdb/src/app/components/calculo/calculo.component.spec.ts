import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CalculoComponent } from './calculo.component';
import { CdbService } from '../../services/cdb.service';
import { of } from 'rxjs';
import { FormsModule } from '@angular/forms';

describe('CalculoComponent', () => {
  let component: CalculoComponent;
  let fixture: ComponentFixture<CalculoComponent>;
  let mockCdbService: jasmine.SpyObj<CdbService>;

  beforeEach(async () => {
    mockCdbService = jasmine.createSpyObj('CdbService', ['calcularCdb']);

    await TestBed.configureTestingModule({
      declarations: [CalculoComponent],
      imports: [FormsModule],
      providers: [{ provide: CdbService, useValue: mockCdbService }]
    }).compileComponents();

    fixture = TestBed.createComponent(CalculoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call cdb service', () => {
    const mockResponse = { valorBruto: 1200, valorLiquido: 1150 };
    mockCdbService.calcularCdb.and.returnValue(of(mockResponse));

    component.valorInicial = 1000;
    component.prazoMeses = 12;
    component.calcularInvestimento();

    expect(mockCdbService.calcularCdb).toHaveBeenCalled();
    expect(component.resultado).toEqual(mockResponse);
  });
});
