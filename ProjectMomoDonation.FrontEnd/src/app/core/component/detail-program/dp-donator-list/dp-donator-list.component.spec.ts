import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DpDonatorListComponent } from './dp-donator-list.component';

describe('DpDonatorListComponent', () => {
  let component: DpDonatorListComponent;
  let fixture: ComponentFixture<DpDonatorListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DpDonatorListComponent]
    });
    fixture = TestBed.createComponent(DpDonatorListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
