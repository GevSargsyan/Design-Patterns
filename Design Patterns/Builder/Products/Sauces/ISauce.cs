using Builder.Products.Product;

namespace Builder.Products.Sauces
{
    internal interface ISauce : IProduct
    {
        string? SauceType { get; set; }
        bool IsThick { get; set; }
    }
}
