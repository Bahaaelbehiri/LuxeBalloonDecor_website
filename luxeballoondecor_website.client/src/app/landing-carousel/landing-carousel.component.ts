import { Component } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-landing-carousel',
  templateUrl: './landing-carousel.component.html',
  styleUrls: ['./landing-carousel.component.css'],
  providers: [NgbCarouselConfig]
})
export class LandingCarouselComponent {
  constructor(config: NgbCarouselConfig) {
    config.interval = 4500;
    config.wrap = true;
    config.keyboard = true;
    config.pauseOnHover = true;
  }
  ngOnInit() {

  }
}
