import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DhDonateListComponent } from './dh-donate-list.component';

describe('DhDonateListComponent', () => {
  let component: DhDonateListComponent;
  let fixture: ComponentFixture<DhDonateListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DhDonateListComponent]
    });
    fixture = TestBed.createComponent(DhDonateListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
