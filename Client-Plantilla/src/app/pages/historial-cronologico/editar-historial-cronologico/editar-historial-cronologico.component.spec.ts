import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarHistorialCronologicoComponent } from './editar-historial-cronologico.component';

describe('EditarHistorialCronologicoComponent', () => {
  let component: EditarHistorialCronologicoComponent;
  let fixture: ComponentFixture<EditarHistorialCronologicoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditarHistorialCronologicoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarHistorialCronologicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
