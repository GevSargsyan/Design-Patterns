using Builder.Products.Product;

namespace Builder.Products.Vegetables
{
    internal class Tomato : VegetableBase
    {
        public Tomato(ProductQuality quality)
          : base("Tomato", PriceConstants.Tomato, nameof(Tomato), quality)
        {
        }
    }
}
