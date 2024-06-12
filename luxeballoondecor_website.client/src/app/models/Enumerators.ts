export enum RoleEnum {
  ADMIN,
  CLIENT,
  VENUECONTACT
}

export enum ContactTypeEnum {
  EMAIL,
  PHONE
}

export enum BookingStatusEnum { // Same as Request Type Enum
  PENDING,
  APPROVED,
  ORDERED,
  RECIEVED,
  CANCELLED
}

export enum FileTypeEnum {
  JPEG,
  PNG,
  GIF,
  BMP,
  MP4,
  MP3
}

export enum AddressTypeEnum {
  HOME,
  MAILING,
  SHIPPING,
  BUISNESS,
  VENUE
}

export enum ModeEnum {
  EMAIL,
  PHONE,
  SMS
}

export enum ElementTypeEnum {
  CARD,
  CAROUSEL,
  TEXTBLOCK
}

export enum CommunicationOutcomeEnum {
  SUCCESS,
  FAILURE,
  PENDING,
  REJECTED
}

export enum FinancialStatusEnum {
  PENDING,
  PROCESSED,
  FAILED,
  RECONCILED
}

// Missing Ones

export enum EntryTypeEnum {
  CHEQUE,
  CREDIT,
  DEBIT,
  CASH,
  PAYPAL,
  CASHAPP,
  VENMO,
  ZELLE
}

export enum ContentTypeEnum {
  GALLERY,
  CARD,
  SERVICES,
  CAROUSEL,
  MISC
}
