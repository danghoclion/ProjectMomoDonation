import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDtdhPageComponent } from './user-dtdh-page.component';

describe('UserDtdhPageComponent', () => {
  let component: UserDtdhPageComponent;
  let fixture: ComponentFixture<UserDtdhPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserDtdhPageComponent]
    });
    fixture = TestBed.createComponent(UserDtdhPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
