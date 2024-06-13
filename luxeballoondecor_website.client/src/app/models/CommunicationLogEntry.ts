import { CommunicationOutcomeEnum, ModeEnum } from "./Enumerators";

export interface CommunicationLogEntry {
  logID: number,
  personID: number,
  date: Date,
  mode: ModeEnum,
  content: string,
  multimediaContentID: number,
  outcome: CommunicationOutcomeEnum
}
