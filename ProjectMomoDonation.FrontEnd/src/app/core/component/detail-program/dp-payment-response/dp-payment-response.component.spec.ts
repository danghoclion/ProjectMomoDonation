import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DpPaymentResponseComponent } from './dp-payment-response.component';

describe('DpPaymentResponseComponent', () => {
  let component: DpPaymentResponseComponent;
  let fixture: ComponentFixture<DpPaymentResponseComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DpPaymentResponseComponent]
    });
    fixture = TestBed.createComponent(DpPaymentResponseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
