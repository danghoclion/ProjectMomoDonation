import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DpStoryComponent } from './dp-story.component';

describe('DpStoryComponent', () => {
  let component: DpStoryComponent;
  let fixture: ComponentFixture<DpStoryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DpStoryComponent]
    });
    fixture = TestBed.createComponent(DpStoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
