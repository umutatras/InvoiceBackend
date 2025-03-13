import { Component, OnInit } from '@angular/core';
import { InvoiceService } from '../invoice.service';

@Component({
  selector: 'app-invoice-list',
  templateUrl: './invoice-list.component.html',
  styleUrls: ['./invoice-list.component.css']
})
export class InvoiceListComponent implements OnInit {
  invoices: any[] = [];
  startDate: Date;
  endDate: Date;
  showUpdateModal = false;
  currentInvoice: any;

  constructor(private invoiceService: InvoiceService) {}

  ngOnInit(): void {
    this.getInvoices();
  }

  getInvoices(): void {
    const start = this.startDate ? this.startDate.toISOString().split('T')[0] : undefined;
    const end = this.endDate ? this.endDate.toISOString().split('T')[0] : undefined;

    this.invoiceService.getAllInvoices(start, end).subscribe({
      next: (data) => {
        console.log('API Response:', data);
        this.invoices = data; // ✅ Artık `data` doğrudan array olduğu için ekstra kontrol yok
      },
      error: (err) => console.error('Hata oluştu:', err)
    });
  }
  toggleDetails(invoiceId: number): void {
    const invoice = this.invoices.find((inv) => inv.id === invoiceId);
    if (invoice) {
      invoice.showDetails = !invoice.showDetails;
    }
  }

  deleteInvoice(invoiceId: any): void {
    this.invoiceService.deleteInvoice(invoiceId).subscribe({
      next: () => {
        this.getInvoices(); // Silme işleminden sonra faturaları tekrar yükleyin
      },
      error: (err) => {
        console.error('Error deleting invoice', err);
      }
    });
  }

  openUpdateModal(invoice: any): void {
    this.currentInvoice = { ...invoice }; // Fatura verisini al
    this.showUpdateModal = true;
  }

  closeUpdateModal(): void {
    this.showUpdateModal = false;
  }
}
