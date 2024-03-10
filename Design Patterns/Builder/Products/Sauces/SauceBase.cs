using Builder.Products.Product;

namespace Builder.Products.Sauces
{
    internal class SauceBase : ProductBase, ISauce
    {
        public SauceBase(string sauceType, bool isThick, decimal price, string name, ProductQuality quality) : base(price, name, quality)
        {
            SauceType = sauceType;
            IsThick = isThick;
        }
        public string? SauceType { get; set; }
        public bool IsThick { get; set; }
        public override string? Type { get; set; } = "Sauce";
    }
}
