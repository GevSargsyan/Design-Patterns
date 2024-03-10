using Builder.Products.Product;

namespace Builder.Products.Cheeses
{
    internal class WhiteCheese : CheeseBase
    {
        public WhiteCheese(ProductQuality quality, MeltLevel meltLevel)
          : base(meltLevel, "White", PriceConstants.WhiteCheese, nameof(WhiteCheese), quality)
        {
        }
    }
}
