// src/app/invoice.service.ts

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { InvoiceAddCommand } from '../app/models/invoice-add.model';

@Injectable({
  providedIn: 'root',
})
export class InvoiceService {
  private apiUrl = 'https://localhost:7289/api/invoice';  // Backend API URL'si

  constructor(private http: HttpClient) {}

  // Yeni fatura eklemek için POST isteği
  addInvoice(command: InvoiceAddCommand): Observable<any> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
    });

    return this.http.post<any>(this.apiUrl, command, { headers });
  }
}
