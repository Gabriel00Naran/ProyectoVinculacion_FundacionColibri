import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarSaludComponent } from './editar-salud.component';

describe('EditarSaludComponent', () => {
  let component: EditarSaludComponent;
  let fixture: ComponentFixture<EditarSaludComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditarSaludComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarSaludComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
