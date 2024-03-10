using Builder.Products.Product;

namespace Builder.Products.Cheeses
{
    internal class YellowCheese : CheeseBase
    {
        public YellowCheese(ProductQuality quality, MeltLevel meltLevel)
            : base(meltLevel, "Yellow", PriceConstants.YellowCheese, nameof(YellowCheese), quality)
        {
        }

    }
}
