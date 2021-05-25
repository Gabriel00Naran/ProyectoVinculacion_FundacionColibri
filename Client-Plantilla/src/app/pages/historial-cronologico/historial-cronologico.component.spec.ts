import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HistorialCronologicoComponent } from './historial-cronologico.component';

describe('HistorialCronologicoComponent', () => {
  let component: HistorialCronologicoComponent;
  let fixture: ComponentFixture<HistorialCronologicoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HistorialCronologicoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HistorialCronologicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
