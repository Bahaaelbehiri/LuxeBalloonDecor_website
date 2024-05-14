import { Component, OnInit } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-landing-carousel',
  templateUrl: './landing-carousel.component.html',
  styleUrls: ['./landing-carousel.component.css']
})
export class LandingCarouselComponent implements OnInit {
  constructor(config: NgbCarouselConfig) {
    config.interval = 2500;
    config.wrap = true;
    config.keyboard = true;
    config.pauseOnHover = false;
  }
  ngOnInit() {

  }
}
