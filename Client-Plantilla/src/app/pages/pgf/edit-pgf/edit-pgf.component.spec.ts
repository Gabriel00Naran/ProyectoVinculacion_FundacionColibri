import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditPgfComponent } from './edit-pgf.component';

describe('EditPgfComponent', () => {
  let component: EditPgfComponent;
  let fixture: ComponentFixture<EditPgfComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditPgfComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditPgfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
