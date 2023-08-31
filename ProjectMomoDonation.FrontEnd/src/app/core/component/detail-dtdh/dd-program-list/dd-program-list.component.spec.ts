import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DdProgramListComponent } from './dd-program-list.component';

describe('DdProgramListComponent', () => {
  let component: DdProgramListComponent;
  let fixture: ComponentFixture<DdProgramListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DdProgramListComponent]
    });
    fixture = TestBed.createComponent(DdProgramListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
