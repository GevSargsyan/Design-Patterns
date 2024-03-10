using Builder.Products.Product;

namespace Builder.Products.Sauces
{
    internal class WhiteSauce : SauceBase
    {
        public WhiteSauce(bool isThick, ProductQuality quality) : base("White", isThick, PriceConstants.WhiteSauce, nameof(WhiteSauce), quality)
        {
        }
    }
}
