import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminProgramIndexComponent } from './admin-program-index.component';

describe('AdminProgramIndexComponent', () => {
  let component: AdminProgramIndexComponent;
  let fixture: ComponentFixture<AdminProgramIndexComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminProgramIndexComponent]
    });
    fixture = TestBed.createComponent(AdminProgramIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
