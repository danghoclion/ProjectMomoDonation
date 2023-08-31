import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DhInformationComponent } from './dh-information.component';

describe('DhInformationComponent', () => {
  let component: DhInformationComponent;
  let fixture: ComponentFixture<DhInformationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DhInformationComponent]
    });
    fixture = TestBed.createComponent(DhInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
