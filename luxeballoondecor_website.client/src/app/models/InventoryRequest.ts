import { BookingStatusEnum } from "./Enumerators";

export interface InventoryRequest {
  requestID: number,
  itemID: number,
  requestedQuantity: number,
  requestedDate: Date,
  requestStatus: BookingStatusEnum
}
