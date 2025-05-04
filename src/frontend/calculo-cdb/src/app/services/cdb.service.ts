import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class CdbService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  calcularCdb(request: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, request);
  }
}
