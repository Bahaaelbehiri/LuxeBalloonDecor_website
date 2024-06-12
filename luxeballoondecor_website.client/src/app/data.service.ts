import { HttpClient } from '@angular/common/http';
import { Injectable, Self } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Address } from './models/Address';
import { Analytics } from './models/Analytics';
import { AddressTypeEnum, BookingStatusEnum } from './models/Enumerators';
import { Booking } from './models/Booking';
import { BookingDetails } from './models/BookingDetails';



@Injectable({
  providedIn: 'root'
})
export class DataService {
  
  address$: BehaviorSubject<Address> = new BehaviorSubject<Address>({
    addressID: 0,
    personID: 0,
    addressType: AddressTypeEnum.VENUE,
    street1: "",
    street2: "",
    city: "",
    state: "",
    zipcode: ""
  });
  analytic$: BehaviorSubject<Analytics> = new BehaviorSubject<Analytics>({
    analyticsID: 0,
    pageID: 0,
    view: 0
  })
  booking$: BehaviorSubject<Booking> = new BehaviorSubject<Booking>({
    bookingID: 0,
    venueID: 0,
    personID: 0,
    dateTime: new Date,
    orderNumber: 0,
    bookingStatus: BookingStatusEnum.PENDING
  });
  bookingDetails$: BehaviorSubject<BookingDetails> = new BehaviorSubject<BookingDetails>({
    bookingDetailsID: 0,
    bookingID: 0
  });

  constructor(private http: HttpClient) { }

  createAddress(address: Address) {
    this.http.post<Address>(`/api/Address/`, address);
  }

  updateAddress(address: Address) {
    this.http.put<Address>(`/api/Address/${address.addressID}`, address);
  }

  removeAddress(addressid: number) {
    this.http.delete<Address>(`/api/Address/${addressid}`);
  }

  // TODO: IDK whats going on
  incrementView(analyticsid: number) {
    this.http.get<Analytics>(`/api/Analytics/${analyticsid}`).subscribe(analytics => {
      analytics.view += 1;
      this.http.put<Analytics>(`/api/Analytics/${analyticsid}`, analytics);
    });
  }

  updateBooking(booking: Booking) {
    this.http.put<Booking>(`/api/Booking/${booking.bookingID}`, booking).subscribe(data => {
      this.getBookingByID(data.bookingID);
    })
  }

  getBookingByID(bookingid: number, getdetailed: boolean = true) {
    this.http.get<Booking>(`/api/Booking/${bookingid}`).subscribe(data => {
      this.booking$.next(data);
      if (getdetailed) {
        this.gatherBookingDetails(data);
      }
    });
  }

  changeBookingStatus(bookingid: number, newstatus: BookingStatusEnum) {
    this.http.get<Booking>(`/api/Booking/${bookingid}`).subscribe(data => {
      data.bookingStatus = newstatus;
      this.updateBooking(data);
    });
  }

  // getDetailedBookingInfo swapped out for getting booking also getting the details by default & duplicate in bookingDetails table
  //getDetailedBookingInfo(booking: Booking) {
  //  this.http.get<BookingDetails>(`/api/BookingDetails/${booking.bookingID}`).subscribe(data => {
  //    this.bookingDetails$.next(data);
  //  });
  //}


  gatherBookingDetails(booking: Booking) {
    this.http.get<BookingDetails>(`/api/BookingDetails/${booking.bookingID}`).subscribe(data => {
      this.bookingDetails$.next(data);
    });
  }

}
