import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailDtdhPageComponent } from './user-detail-dtdh-page.component';

describe('UserDetailDtdhPageComponent', () => {
  let component: UserDetailDtdhPageComponent;
  let fixture: ComponentFixture<UserDetailDtdhPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserDetailDtdhPageComponent]
    });
    fixture = TestBed.createComponent(UserDetailDtdhPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
