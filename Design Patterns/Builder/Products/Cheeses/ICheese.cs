using Builder.Products.Product;

namespace Builder.Products.Cheeses
{
    internal interface ICheese : IProduct
    {
        string? CheeseType { get; set; }
        MeltLevel? MeltLevel { get; set; }
    }
}
