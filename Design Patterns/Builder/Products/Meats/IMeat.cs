using Builder.Products.Product;

namespace Builder.Products.Meats
{
    internal interface IMeat : IProduct
    {
        string? MeatType { get; set; }
        DonenessType Doneness { get; set; }
    }
}
