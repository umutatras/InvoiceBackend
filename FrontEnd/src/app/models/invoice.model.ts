export class InvoiceUpdateRequestDto {
  itemName: string;
  quantity: number;
  price: number;

  constructor(itemName: string, quantity: number, price: number) {
    this.itemName = itemName;
    this.quantity = quantity;
    this.price = price;
  }
}

export class Invoice {
  id: number;
  customerId: number;
  invoiceNumber: string;
  invoiceDate: Date;
  totalAmount: number;
  invoiceLines: InvoiceUpdateRequestDto[];
  showDetails?: boolean;  // ✅ Yeni özellik eklendi!

  constructor(
    id: number,
    customerId: number,
    invoiceNumber: string,
    invoiceDate: Date,
    totalAmount: number,
    invoiceLines: InvoiceUpdateRequestDto[],
    showDetails: boolean = false  // ✅ Varsayılan olarak false ayarlandı
  ) {
    this.id = id;
    this.customerId = customerId;
    this.invoiceNumber = invoiceNumber;
    this.invoiceDate = invoiceDate;
    this.totalAmount = totalAmount;
    this.invoiceLines = invoiceLines;
    this.showDetails = showDetails;
  }
}
export class InvoiceDeleteCommand {
  id: number | undefined;  // Bu alanda id tanımlı olmalı
}
