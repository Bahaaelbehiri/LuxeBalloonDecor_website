import { FinancialStatusEnum } from "./Enumerators";

export interface InvoiceDetails {
  invoiceDetailsID: number,
  financialRecordID: number,
  amount: number,
  dateTime: Date,
  status: FinancialStatusEnum,
  reciptDetails: string,
  paymentDetails: string
}
