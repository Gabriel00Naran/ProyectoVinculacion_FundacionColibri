import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerHistorialCronologicoComponent } from './ver-historial-cronologico.component';

describe('VerHistorialCronologicoComponent', () => {
  let component: VerHistorialCronologicoComponent;
  let fixture: ComponentFixture<VerHistorialCronologicoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerHistorialCronologicoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerHistorialCronologicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
