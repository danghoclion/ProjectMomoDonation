import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminProgramCreateComponent } from './admin-program-create.component';

describe('AdminProgramCreateComponent', () => {
  let component: AdminProgramCreateComponent;
  let fixture: ComponentFixture<AdminProgramCreateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminProgramCreateComponent]
    });
    fixture = TestBed.createComponent(AdminProgramCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
