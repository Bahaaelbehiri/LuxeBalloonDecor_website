import { HttpClient } from '@angular/common/http';
import { Injectable, Self } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Image } from './models/image';
import { Booking } from './models/booking';
import { Customer } from './models/customer';
import { Testimonial } from './models/testimonial';
import { InventoryItem } from './models/inventory_item';



@Injectable({
  providedIn: 'root'
})
export class DataService {

  images$: BehaviorSubject<Image[]> = new BehaviorSubject<Image[]>([]);
  image$: BehaviorSubject<Image> = new BehaviorSubject<Image>({
    ID: 0,
    URL: '',
    name: '',
    shortDescription: ''
  });

  bookings$: BehaviorSubject<Booking[]> = new BehaviorSubject<Booking[]>([]);
  booking$: BehaviorSubject<Booking> = new BehaviorSubject<Booking>({
    ID: 0,
    customerID: 0,
    bookingDate: new Date,
    bookingItems: {
      $values: []
    }
  });

  customers$: BehaviorSubject<Customer[]> = new BehaviorSubject<Customer[]>([]);
  customer$: BehaviorSubject<Customer> = new BehaviorSubject<Customer>({
    ID: 0,
    firstName: '',
    lastName: '',
    contact: ''
  });

  testimonials$: BehaviorSubject<Testimonial[]> = new BehaviorSubject<Testimonial[]>([]);
  testimonial$: BehaviorSubject<Testimonial> = new BehaviorSubject<Testimonial>({
    ID: 0,
    title: '',
    date: new Date,
    description: '',
    initials: ''
  });

  inventoryitems$: BehaviorSubject<InventoryItem[]> = new BehaviorSubject<InventoryItem[]>([]);
  inventoryitem$: BehaviorSubject<InventoryItem> = new BehaviorSubject<InventoryItem>({
    ID: 0,
    image: {
      ID: 0,
      URL: '',
      name: '',
      shortDescription: ''
    },
    title: '',
    description: '',
    variants: {
      $values: []
    }
  });
  constructor(private http: HttpClient) { }

  getAllImages() {
    this.http.get<Image[]>("/api/Image").subscribe(data => {
      this.images$.next(data);
    })
  }
  getImageByID(id: number) {
    this.http.get<Image>(`/api/Image/${id}`).subscribe(data => {
      this.image$.next(data);
    })
  }

  getAllBookings() {
    this.http.get<Booking[]>("/api/Booking").subscribe(data => {
      this.bookings$.next(data);
    })
  }
  getBookingByID(id: number) {
    this.http.get<Booking>(`/api/Booking${id}`).subscribe(data => {
      this.booking$.next(data);
      this.inventoryitems$.next(data.bookingItems.$values);
    })
  }
}
