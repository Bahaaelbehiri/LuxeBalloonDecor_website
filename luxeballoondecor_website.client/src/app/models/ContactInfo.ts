import { ContactTypeEnum } from "./Enumerators";

export interface ContactInfo {
  contactInfoID: number,
  personID: number,
  contactType: ContactTypeEnum,
  value: string
}
