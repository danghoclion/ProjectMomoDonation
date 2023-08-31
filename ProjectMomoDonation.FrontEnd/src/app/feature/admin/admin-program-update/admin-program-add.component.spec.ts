import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminProgramUpdateComponent } from './admin-program-add.component';

describe('AdminProgramUpdateComponent', () => {
  let component: AdminProgramUpdateComponent;
  let fixture: ComponentFixture<AdminProgramUpdateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminProgramUpdateComponent]
    });
    fixture = TestBed.createComponent(AdminProgramUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
