import { Booking } from "./booking";
import { Customer } from "./customer";

export interface CustomerBookings {
  customerID: number,
  customer: Customer,
  bookingID: number,
  booking: Booking
}
