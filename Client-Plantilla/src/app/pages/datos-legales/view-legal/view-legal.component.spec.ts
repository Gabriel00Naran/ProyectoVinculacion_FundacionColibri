import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewLegalComponent } from './view-legal.component';

describe('ViewLegalComponent', () => {
  let component: ViewLegalComponent;
  let fixture: ComponentFixture<ViewLegalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewLegalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewLegalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
