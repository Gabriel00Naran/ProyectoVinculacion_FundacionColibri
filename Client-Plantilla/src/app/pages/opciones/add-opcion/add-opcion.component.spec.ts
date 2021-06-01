import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddOpcionComponent } from './add-opcion.component';

describe('AddOpcionComponent', () => {
  let component: AddOpcionComponent;
  let fixture: ComponentFixture<AddOpcionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddOpcionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddOpcionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
