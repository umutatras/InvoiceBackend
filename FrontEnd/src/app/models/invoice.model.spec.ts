import { Invoice } from './invoice.model';

describe('Invoice Model', () => {
  it('should create an instance', () => {
    const testInvoice = new Invoice(1, 123, 'INV-001', new Date(), 250.75, []);
    expect(testInvoice).toBeTruthy();
  });
});
