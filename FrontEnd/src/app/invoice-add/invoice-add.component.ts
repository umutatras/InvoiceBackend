// src/app/invoice.component.ts

import { Component } from '@angular/core';
import { InvoiceService } from '../invoice-add.service';
import { InvoiceAddCommand, InvoiceAddRequestDto } from '../models/invoice-add.model';

@Component({
  selector: 'app-invoice-add',
  templateUrl: './invoice-add.component.html',
})
export class InvoiceComponent {
  invoice: InvoiceAddCommand = {
    customerId: 0,
    invoiceNumber: '',
    invoiceDate: '',
    totalAmount: 0,
    invoiceLines: [],
  };

  // Formdan yeni satır eklemek için
  addInvoiceLine() {
    const newLine: InvoiceAddRequestDto = {
      itemName: '',
      quantity: 0,
      price: 0,
    };
    this.invoice.invoiceLines.push(newLine);
  }

  // Fatura ekleme fonksiyonu
  addInvoice() {
    if (this.invoice.customerId && this.invoice.invoiceNumber && this.invoice.invoiceDate) {
      this.invoiceService.addInvoice(this.invoice).subscribe(
        (response) => {
          console.log('Invoice added successfully', response);
          alert('Invoice added successfully');
        },
        (error) => {
          console.error('Error adding invoice', error);
          alert('Error adding invoice');
        }
      );
    } else {
      alert('Please fill in all required fields.');
    }
  }

  constructor(private invoiceService: InvoiceService) {}
}
