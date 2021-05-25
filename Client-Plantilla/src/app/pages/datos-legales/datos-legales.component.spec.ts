import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DatosLegalesComponent } from './datos-legales.component';

describe('DatosLegalesComponent', () => {
  let component: DatosLegalesComponent;
  let fixture: ComponentFixture<DatosLegalesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DatosLegalesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DatosLegalesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
