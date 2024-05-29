import { HttpClient } from '@angular/common/http';
import { Injectable, Self } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Address } from './models/Address';
import { Analytics } from './models/Analytics';
import { Booking } from './models/Booking';
import { BookingStatusEnum } from './models/Enumerators';



@Injectable({
  providedIn: 'root'
})
export class DataService {

  booking$: BehaviorSubject<Booking> = new BehaviorSubject<Booking>({
    bookingID: 0,
    venueID: 0,
    personID: 0,
    dateTime: new Date,
    orderNumber: 0,
    bookingStatus: BookingStatusEnum.PENDING
  });

  constructor(private http: HttpClient) { }

  updateAddress(address: Address) {
    this.http.put<Address>(`/api/Address/${address.addressID}`, address);
  }

  removeAddress(addressid: number) {
    this.http.delete<Address>(`/api/Address/${addressid}`);
  }

  // TODO: Figure out the best way to do this
  incrementViews(analyticsid: number) {
    let updateAnalytics: Analytics = this.http.get<Analytics>(`/api/Analytics/${analyticsid}`).subscribe(analytics => {
      updateAnalytics.analyticsID = analytics.analyticsID;
      updateAnalytics.pageID = analytics.pageID;
      updateAnalytics.view = analytics.view + 1;
    });
    
    this.http.put(`/api/Analytics/${analyticsid}`, updateAnalytics);
  }

  updateBooking(newbooking: Booking) {
    this.http.put<Booking>(`/api/Booking/${newbooking.bookingID}`, newbooking).subscribe(data => {
      this.getBookingByID(data.bookingID);
    })
  }

  getBookingByID(bookingid: number) {
    this.http.get<Booking>(`/api/Booking/${bookingid}`).subscribe(data => {
      this.booking$.next(data);
    })
  }


}
