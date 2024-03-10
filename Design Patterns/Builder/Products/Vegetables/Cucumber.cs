using Builder.Products.Product;

namespace Builder.Products.Vegetables
{
    internal class Cucumber : VegetableBase
    {
        public Cucumber(ProductQuality quality)
        : base("Cucumber", PriceConstants.Cucumber, nameof(Cucumber), quality)
        {
        }
    }
}
