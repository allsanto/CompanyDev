import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiretorComponent } from './diretor.component';

describe('DiretorComponent', () => {
  let component: DiretorComponent;
  let fixture: ComponentFixture<DiretorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiretorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiretorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
