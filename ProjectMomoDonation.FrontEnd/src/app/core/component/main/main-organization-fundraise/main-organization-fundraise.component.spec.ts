import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainOrganizationFundraiseComponent } from './main-organization-fundraise.component';

describe('MainOrganizationFundraiseComponent', () => {
  let component: MainOrganizationFundraiseComponent;
  let fixture: ComponentFixture<MainOrganizationFundraiseComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainOrganizationFundraiseComponent]
    });
    fixture = TestBed.createComponent(MainOrganizationFundraiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
