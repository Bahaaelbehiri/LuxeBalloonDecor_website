import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-rental-item',
  templateUrl: './rental-item.component.html',
  styleUrls: ['./rental-item.component.css']
})
export class RentalItemComponent {
  @Input() rental: any; // Define the rental input
}
