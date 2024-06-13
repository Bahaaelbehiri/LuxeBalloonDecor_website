import { ElementTypeEnum } from "./Enumerators";

export interface PageElement {
  elementID: number,
  pageID: number,
  elementType: ElementTypeEnum,
  content: string,
  multimediaContentID: number,
  title: string,
  description: string,
  price: number
}
