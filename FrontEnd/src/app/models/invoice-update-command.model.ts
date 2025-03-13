export class InvoiceUpdateCommand {
  id: number=0;
  customerId: number=0;
  invoiceNumber: string="";
  invoiceDate: string=""; // veya Date
  totalAmount: number=0;
  invoiceLines: InvoiceLine[] = [];
}

export class InvoiceLine {
  itemName: string="";
  quantity: number=0;
  price: number=0;
}
