import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarHistorialCronologicoComponent } from './agregar-historial-cronologico.component';

describe('AgregarHistorialCronologicoComponent', () => {
  let component: AgregarHistorialCronologicoComponent;
  let fixture: ComponentFixture<AgregarHistorialCronologicoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgregarHistorialCronologicoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AgregarHistorialCronologicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
