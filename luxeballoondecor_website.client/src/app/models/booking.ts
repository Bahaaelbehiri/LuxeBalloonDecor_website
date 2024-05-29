import { BookingStatusEnum } from "./Enumerators";

export interface Booking {
  bookingID: number,
  venueID: number,
  personID: number,
  dateTime: Date,
  orderNumber: number,
  bookingStatus: BookingStatusEnum
}
