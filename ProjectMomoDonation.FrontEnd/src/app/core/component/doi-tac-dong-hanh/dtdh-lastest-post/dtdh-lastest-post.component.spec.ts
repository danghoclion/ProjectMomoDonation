import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DtdhLastestPostComponent } from './dtdh-lastest-post.component';

describe('DtdhLastestPostComponent', () => {
  let component: DtdhLastestPostComponent;
  let fixture: ComponentFixture<DtdhLastestPostComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DtdhLastestPostComponent]
    });
    fixture = TestBed.createComponent(DtdhLastestPostComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
