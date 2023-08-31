import { TestBed } from '@angular/core/testing';

import { DonationProgramService } from './donation-program-service.service';

describe('DonationProgramServiceService', () => {
  let service: DonationProgramService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DonationProgramService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
