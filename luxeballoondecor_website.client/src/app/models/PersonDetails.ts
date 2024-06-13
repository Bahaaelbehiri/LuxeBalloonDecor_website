import { ContactInfo } from "./ContactInfo";
import { RoleEnum } from "./Enumerators";

export interface PersonDetails{
  personID: number,
  firstName: string,
  lastName: string,
  birthDate: Date,
  role: RoleEnum,
  testimonials: string[],
  contactDetails: ContactInfo[]
}
