import { HttpClient } from '@angular/common/http';
import { Injectable, Self } from '@angular/core';
import { Observable } from 'rxjs';
import { Address } from './models/Address';
import { Analytics } from './models/Analytics';
import { AddressTypeEnum, BookingStatusEnum } from './models/Enumerators';
import { Booking } from './models/Booking';
import { BookingDetails } from './models/BookingDetails';
import { InventoryItem } from './models/InventoryItem';
import { BookingInventory } from './models/BookingInventory';
import { CommunicationLogEntry } from './models/CommunicationLogEntry';
import { ContactInfo } from './models/ContactInfo';
import { FinancialRecord } from './models/FinancialRecord';
import { UsageDetails } from './models/UsageDetails';
import { InventoryRequest } from './models/InventoryRequest';
import { MultimediaContent } from './models/MultimediaContent';
import { PageElement } from './models/PageElement';
import { Page } from './models/Page';
import { StyleSettings } from './models/StyleSettings';
import { Venue } from './models/Venue';



@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  createAddress(address: Address): Observable<Address> {
    return this.http.post<Address>(`/api/Address/`, address);
  }

  updateAddress(address: Address): Observable<Address> {
    return this.http.put<Address>(`/api/Address/${address.addressID}`, address);
  }

  removeAddress(addressid: number): Observable<Address> {
    return this.http.delete<Address>(`/api/Address/${addressid}`);
  }

  // TODO: IDK whats going on
  incrementView(analyticsid: number) {
    this.http.get<Analytics>(`/api/Analytics/${analyticsid}`).subscribe(analytics => {
      analytics.view += 1;
      this.http.put<Analytics>(`/api/Analytics/${analyticsid}`, analytics);
    });
  }

  updateBooking(booking: Booking): Observable<Booking> {
    return this.http.put<Booking>(`/api/Booking/${booking.bookingID}`, booking);
  }

  getBookingByID(bookingid: number, getdetailed: boolean = true): Observable<Booking> {
    return this.http.get<Booking>(`/api/Booking/${bookingid}`);
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


  gatherBookingDetails(booking: Booking): Observable<BookingDetails> {
    return this.http.get<BookingDetails>(`/api/BookingDetails/${booking.bookingID}`);
  }

  getInventoryItems(booking: Booking): Observable<BookingInventory> {
    return this.http.get<BookingInventory>(`/api/BookingInventory/${booking.bookingID}`);
  }

  logCommunication(newentry: CommunicationLogEntry): Observable<CommunicationLogEntry> {
    return this.http.put<CommunicationLogEntry>(`/api/CommunicationLogEntry/${newentry.logID}`, newentry);
  }

  getLogsByPerson(personid: number): Observable<CommunicationLogEntry[]> {
    return this.http.get<CommunicationLogEntry[]>(`/api/CommunicationLogEntry/${personid}`);
  }

  updateContact(newcontact: ContactInfo): Observable<ContactInfo> {
    return this.http.put<ContactInfo>(`/api/ContactInfo/${newcontact.contactInfoID}`, newcontact);
  }

  deleteContact(contactid: number): Observable<ContactInfo> {
    return this.http.delete<ContactInfo>(`/api/ContactInfo/${contactid}`);
  }

  modifyRecord(newrecord: FinancialRecord): Observable<FinancialRecord> {
    return this.http.put<FinancialRecord>(`/api/FinancialRecord/${newrecord.financialRecordID}`, newrecord);
  }

  // TODO: Figure out ways to do this, as it sits. will need to do in modify record
  //generateInvoice() {

  //}

  //TODO: Complete this when incriment views is done
  //updateInventoryQuantity(inventoryid: number, newquantity: number) {

  //}

  // TODO: Figure out pipe, documentation confusing (Track usage alternative)
  getUsageDetails(usageid: number): Observable<UsageDetails> {
    return this.http.get<UsageDetails>(`/api/UsageDetails/${usageid}`);
  }

  createRequest(newrequest: InventoryRequest): Observable<InventoryRequest> {
    return this.http.post<InventoryRequest>(`/api/InventoryRequest/${newrequest.requestID}`, newrequest);
  }

  updateRequest(request: InventoryRequest): Observable<InventoryRequest> {
    return this.http.put<InventoryRequest>(`/api/InventoryRequest/${request.requestID}`, request);
  }

  deleteRequest(request: InventoryRequest): Observable<InventoryRequest> {
    return this.http.delete<InventoryRequest>(`/api/InventoryRequest/${request.requestID}`);
  }

  uploadContent(newcontent: MultimediaContent): Observable<MultimediaContent> {
    return this.http.post<MultimediaContent>(`/api/MultimediaContent/${newcontent.multimediaContentID}`, newcontent);
  }

  deleteContent(contentid: number): Observable<MultimediaContent> {
    return this.http.delete<MultimediaContent>(`/api/MultimediaContent/${contentid}`);
  }

  // Use for filepath & description
  updateContent(newcontent: MultimediaContent): Observable<MultimediaContent> {
    return this.http.put<MultimediaContent>(`/api/MultimediaContent/${newcontent.multimediaContentID}`, newcontent);
  }

  addElement(element: PageElement): Observable<PageElement> {
    return this.http.post<PageElement>(`/api/PageElement/${element.elementID}`, element);
  }

  removeElement(elementid: number): Observable<PageElement> {
    return this.http.delete<PageElement>(`/api/PageElement/${elementid}`);
  }

  // Use for update font & update color scheme
  updateStyles(newstyle: StyleSettings): Observable<StyleSettings> {
    return this.http.put<StyleSettings>(`/api/StyleSettings/${newstyle.settingsID}`, newstyle);
  }

  //TODO: impliment like view counter
  //trackView() {

  //}

  updateVenue(updatedvenue: Venue): Observable<Venue> {
    return this.http.put<Venue>(`/api/Venue/${updatedvenue.venueID}`, updatedvenue);
  }

  // TODO: figure out Assign contact
  //assignContact(contactinfoid: number) {

  //}

  //TODO Finish
  //searchVenue(name: string): Observable<Venue[]> {
  //  this.http.get<Venue>(`/api/Venue/`).subscribe(data => {
      
  //  });
  //}
}
