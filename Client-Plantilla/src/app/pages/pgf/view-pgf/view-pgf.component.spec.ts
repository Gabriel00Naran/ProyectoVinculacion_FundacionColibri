import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewPgfComponent } from './view-pgf.component';

describe('ViewPgfComponent', () => {
  let component: ViewPgfComponent;
  let fixture: ComponentFixture<ViewPgfComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewPgfComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewPgfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
