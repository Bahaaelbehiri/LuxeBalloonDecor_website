import { Component, AfterViewInit, ElementRef } from '@angular/core';

@Component({
  selector: 'carousel',
  templateUrl: './landing-carousel.component.html',
  styleUrls: ['./landing-carousel.component.css'],
})
export class LandingCarouselComponent implements AfterViewInit {
  constructor(private elRef: ElementRef) { }

  ngAfterViewInit() {
    // Adjust the scroll position after a slight delay to ensure everything is rendered
    setTimeout(() => {
      const carouselElement = this.elRef.nativeElement.querySelector('#carouselExampleAutoplaying');
      if (carouselElement) {
        const scrollPosition = carouselElement.offsetTop +300; // Get the position of the carousel
        window.scrollTo({
          top: scrollPosition, // Scroll to the top position of the carousel
          behavior: 'smooth'
        });
      }
    }, 100); // Adjust the delay as needed
  }
}
