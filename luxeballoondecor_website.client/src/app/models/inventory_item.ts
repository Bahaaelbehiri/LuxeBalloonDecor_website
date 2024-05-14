import { Image } from "./image";
import { InventoryVariants } from "./inventory_variants"

export interface InventoryItemVariants {
  $values: InventoryVariants[]
}

export interface InventoryItem {
  ID: number,
  image: Image,
  title: string,
  description: string,
  variants: InventoryItemVariants
}
