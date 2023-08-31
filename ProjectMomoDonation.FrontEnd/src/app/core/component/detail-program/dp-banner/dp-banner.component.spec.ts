import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DpBannerComponent } from './dp-banner.component';

describe('DpBannerComponent', () => {
  let component: DpBannerComponent;
  let fixture: ComponentFixture<DpBannerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DpBannerComponent]
    });
    fixture = TestBed.createComponent(DpBannerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
