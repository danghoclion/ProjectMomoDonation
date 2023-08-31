import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserDetailProgramPageComponent } from './user-detail-program-page.component';

describe('UserDetailProgramPageComponent', () => {
  let component: UserDetailProgramPageComponent;
  let fixture: ComponentFixture<UserDetailProgramPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserDetailProgramPageComponent],
    });
    fixture = TestBed.createComponent(UserDetailProgramPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
