import { VariantPrice } from "./variant_price";

export interface InventoryVariantPrices {
  $values: VariantPrice[]
}

export interface InventoryVariants {
  itemID: number,
  prices: InventoryVariantPrices
}
