import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPgfComponent } from './add-pgf.component';

describe('AddPgfComponent', () => {
  let component: AddPgfComponent;
  let fixture: ComponentFixture<AddPgfComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddPgfComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPgfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
