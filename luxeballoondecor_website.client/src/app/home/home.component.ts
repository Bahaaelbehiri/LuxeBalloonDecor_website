import { DOCUMENT } from '@angular/common';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit {

  constructor(@Inject(DOCUMENT) private document: Document) { }

  ngOnInit(): void {
    this.scrollToTop();
  }

  scrollToTop(): void {
    this.document.body.scrollTop = 0; // For Safari
    this.document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE, and Opera
  }
}
