import { InventoryItem } from "./inventory_item"

export interface BookingInventory {
  $values: InventoryItem[]
}

export interface Booking {
  ID: number,
  customerID: number,
  bookingDate: Date,
  bookingItems: BookingInventory
}
