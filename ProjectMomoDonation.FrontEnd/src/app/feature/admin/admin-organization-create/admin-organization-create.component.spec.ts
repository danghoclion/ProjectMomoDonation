import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminOrganizationCreateComponent } from './admin-organization-create.component';

describe('AdminOrganizationCreateComponent', () => {
  let component: AdminOrganizationCreateComponent;
  let fixture: ComponentFixture<AdminOrganizationCreateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminOrganizationCreateComponent]
    });
    fixture = TestBed.createComponent(AdminOrganizationCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
