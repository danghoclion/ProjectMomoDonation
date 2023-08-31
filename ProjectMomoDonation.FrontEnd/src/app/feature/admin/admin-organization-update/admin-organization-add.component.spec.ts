import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminOrganizationUpdateComponent } from './admin-organization-add.component';

describe('AdminOrganizationUpdateComponent', () => {
  let component: AdminOrganizationUpdateComponent;
  let fixture: ComponentFixture<AdminOrganizationUpdateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminOrganizationUpdateComponent]
    });
    fixture = TestBed.createComponent(AdminOrganizationUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
