import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Invoice, InvoiceDeleteCommand } from './models/invoice.model';
import { InvoiceUpdateCommand } from './models/invoice-update-command.model';

interface ApiResponse {
  data: Invoice[];  // data, dizi türünde dönecek
  message: string;
  success: boolean;
  errors: any;
}

@Injectable({
  providedIn: 'root'
})
export class InvoiceService {
  private apiUrl = 'https://localhost:7289/api/invoice';

  constructor(private http: HttpClient) {}

  getAllInvoices(startDate?: string, endDate?: string): Observable<Invoice[]> {
    let url = `${this.apiUrl}?`;
    if (startDate) url += `startDate=${startDate}&`;
    if (endDate) url += `endDate=${endDate}`;

    return this.http.get<ApiResponse>(url).pipe(
      map(response => response.data)  // `data` array'ini döndürüyoruz
    );
  }
  deleteInvoice(command: InvoiceDeleteCommand): Observable<any> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
    });

    return this.http.delete<any>(this.apiUrl, { headers, body: command });
  }
  updateInvoice(command: InvoiceUpdateCommand): Observable<any> {
    return this.http.put(this.apiUrl, command);
  }
}
