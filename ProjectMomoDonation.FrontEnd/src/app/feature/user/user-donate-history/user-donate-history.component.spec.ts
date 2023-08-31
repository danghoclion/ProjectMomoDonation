import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDonateHistoryComponent } from './user-donate-history.component';

describe('UserDonateHistoryComponent', () => {
  let component: UserDonateHistoryComponent;
  let fixture: ComponentFixture<UserDonateHistoryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserDonateHistoryComponent]
    });
    fixture = TestBed.createComponent(UserDonateHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
