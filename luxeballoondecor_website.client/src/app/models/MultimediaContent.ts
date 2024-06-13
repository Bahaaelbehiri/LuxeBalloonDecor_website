import { ContentTypeEnum, FileTypeEnum } from "./Enumerators";

export interface MultimediaContent {
  multimediaContentID: number,
  contentType: ContentTypeEnum,
  filePath: string,
  filesize: number,
  fileFormat: FileTypeEnum,
  description: string
}
