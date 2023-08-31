import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserHcqgPageComponent } from './user-hcqg-page.component';

describe('UserHcqgPageComponent', () => {
  let component: UserHcqgPageComponent;
  let fixture: ComponentFixture<UserHcqgPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserHcqgPageComponent]
    });
    fixture = TestBed.createComponent(UserHcqgPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
