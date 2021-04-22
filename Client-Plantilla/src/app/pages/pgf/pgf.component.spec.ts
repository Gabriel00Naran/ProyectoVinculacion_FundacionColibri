import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PgfComponent } from './pgf.component';

describe('PgfComponent', () => {
  let component: PgfComponent;
  let fixture: ComponentFixture<PgfComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PgfComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PgfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
