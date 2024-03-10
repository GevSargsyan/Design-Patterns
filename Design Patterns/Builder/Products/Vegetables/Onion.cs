using Builder.Products.Product;

namespace Builder.Products.Vegetables
{
    internal class Onion : VegetableBase
    {
        public Onion(ProductQuality quality)
            : base("Onion", PriceConstants.Onion, nameof(Onion), quality)
        {
        }
    }
}
