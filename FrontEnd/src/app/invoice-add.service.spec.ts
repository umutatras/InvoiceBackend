import { TestBed } from '@angular/core/testing';

import { InvoiceAddService } from './invoice-add.service';

describe('InvoiceAddService', () => {
  let service: InvoiceAddService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InvoiceAddService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
