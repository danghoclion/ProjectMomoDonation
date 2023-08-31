import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DtdhOrganizationComponent } from './dtdh-organization.component';

describe('DtdhOrganizationComponent', () => {
  let component: DtdhOrganizationComponent;
  let fixture: ComponentFixture<DtdhOrganizationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DtdhOrganizationComponent]
    });
    fixture = TestBed.createComponent(DtdhOrganizationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
