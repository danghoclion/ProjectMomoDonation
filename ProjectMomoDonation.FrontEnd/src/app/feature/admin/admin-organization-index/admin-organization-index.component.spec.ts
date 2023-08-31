import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminOrganizationIndexComponent } from './admin-organization-index.component';

describe('AdminOrganizationIndexComponent', () => {
  let component: AdminOrganizationIndexComponent;
  let fixture: ComponentFixture<AdminOrganizationIndexComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminOrganizationIndexComponent]
    });
    fixture = TestBed.createComponent(AdminOrganizationIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
