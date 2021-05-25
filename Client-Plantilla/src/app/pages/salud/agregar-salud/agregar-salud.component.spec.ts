import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarSaludComponent } from './agregar-salud.component';

describe('AgregarSaludComponent', () => {
  let component: AgregarSaludComponent;
  let fixture: ComponentFixture<AgregarSaludComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgregarSaludComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AgregarSaludComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
