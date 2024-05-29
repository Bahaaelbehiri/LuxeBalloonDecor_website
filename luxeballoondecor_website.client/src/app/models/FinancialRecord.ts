import { EntryTypeEnum, FinancialStatusEnum } from "./Enumerators";

export interface FinancialRecord {
  financialRecordID: number,
  bookingID: number,
  personID: number,
  entryType: EntryTypeEnum, // TODO: Fix with proper ENUM
  status: FinancialStatusEnum,
  amount: number,
  dateTime: Date,
  invoiceDetailsID: number
}
