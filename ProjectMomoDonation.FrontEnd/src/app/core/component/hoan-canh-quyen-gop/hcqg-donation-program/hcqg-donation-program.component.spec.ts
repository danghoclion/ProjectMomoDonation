import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HcqgDonationProgramComponent } from './hcqg-donation-program.component';

describe('HcqgDonationProgramComponent', () => {
  let component: HcqgDonationProgramComponent;
  let fixture: ComponentFixture<HcqgDonationProgramComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HcqgDonationProgramComponent]
    });
    fixture = TestBed.createComponent(HcqgDonationProgramComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
