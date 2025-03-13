import { Component, Input, Output, EventEmitter } from '@angular/core';
import { InvoiceService } from '../invoice.service';
import { InvoiceUpdateCommand } from '../models/invoice-update-command.model';  // Modeli buraya import ediyoruz

@Component({
  selector: 'app-invoice-update',
  templateUrl: './invoice-update.component.html',
  styleUrls: ['./invoice-update.component.css']
})
export class InvoiceUpdateComponent {
  @Input() invoice: InvoiceUpdateCommand;
  @Output() close = new EventEmitter<void>();

  constructor(private invoiceService: InvoiceService) {}

  updateInvoice(): void {
    this.invoiceService.updateInvoice(this.invoice).subscribe({
      next: () => {
        this.close.emit(); // Modal'ı kapat
      },
      error: (err) => {
        console.error('Error updating invoice', err);
      }
    });
  }

  closeModal(): void {
    this.close.emit(); // Modal'ı kapat
  }
}
