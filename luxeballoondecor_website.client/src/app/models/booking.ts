import { InventoryItem } from "./inventory_item"

export interface BookingInventory {
  $values: InventoryItem[]
}

export interface Booking {
  customerID: number,
  bookingDate: Date,
  bookingItems: BookingInventory
}
