import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HcqgCategoryFilterComponent } from './hcqg-category-filter.component';

describe('HcqgCategoryFilterComponent', () => {
  let component: HcqgCategoryFilterComponent;
  let fixture: ComponentFixture<HcqgCategoryFilterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HcqgCategoryFilterComponent]
    });
    fixture = TestBed.createComponent(HcqgCategoryFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
