import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LandingCarouselComponent } from './landing-carousel.component';

describe('LandingCarouselComponent', () => {
  let component: LandingCarouselComponent;
  let fixture: ComponentFixture<LandingCarouselComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LandingCarouselComponent]
    });
    fixture = TestBed.createComponent(LandingCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
