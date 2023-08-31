import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainDonationProgramComponent } from './main-donation-program.component';

describe('MainDonationProgramComponent', () => {
  let component: MainDonationProgramComponent;
  let fixture: ComponentFixture<MainDonationProgramComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainDonationProgramComponent]
    });
    fixture = TestBed.createComponent(MainDonationProgramComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
