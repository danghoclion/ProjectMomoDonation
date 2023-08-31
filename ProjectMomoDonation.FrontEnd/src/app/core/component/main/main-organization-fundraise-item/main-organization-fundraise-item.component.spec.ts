import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainOrganizationFundraiseItemComponent } from './main-organization-fundraise-item.component';

describe('MainOrganizationFundraiseItemComponent', () => {
  let component: MainOrganizationFundraiseItemComponent;
  let fixture: ComponentFixture<MainOrganizationFundraiseItemComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainOrganizationFundraiseItemComponent]
    });
    fixture = TestBed.createComponent(MainOrganizationFundraiseItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
