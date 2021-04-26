import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VerSaludComponent } from './ver-salud.component';

describe('VerSaludComponent', () => {
  let component: VerSaludComponent;
  let fixture: ComponentFixture<VerSaludComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VerSaludComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VerSaludComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
