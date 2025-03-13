// src/app/invoice.model.ts

export class InvoiceAddRequestDto {
  itemName: string = '';  // Başlatıcı değer ekledik
  quantity: number = 0;   // Başlatıcı değer ekledik
  price: number = 0;      // Başlatıcı değer ekledik
}

export class InvoiceAddCommand {
  customerId: number = 0;
  invoiceNumber: string = '';
  invoiceDate: string = '';  // Tarihi başlatıcı değeri ile başlatıyoruz
  totalAmount: number = 0;
  invoiceLines: InvoiceAddRequestDto[] = [];
}
