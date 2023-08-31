import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainDonationProgramItemComponent } from './main-donation-program-item.component';

describe('MainDonationProgramItemComponent', () => {
  let component: MainDonationProgramItemComponent;
  let fixture: ComponentFixture<MainDonationProgramItemComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainDonationProgramItemComponent]
    });
    fixture = TestBed.createComponent(MainDonationProgramItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
