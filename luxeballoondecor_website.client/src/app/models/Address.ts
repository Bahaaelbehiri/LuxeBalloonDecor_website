import { AddressTypeEnum } from "./Enumerators";

export interface Address {
  addressID: number,
  personID: number,
  addressType: AddressTypeEnum,
  street1: string,
  street2: string,
  city: string,
  state: string,
  zipcode: string
}
