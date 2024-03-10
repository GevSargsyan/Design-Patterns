using Builder.Products.Product;

namespace Builder.Products.Breads
{
    internal interface IBread : IProduct
    {
        string? BreadType { get; set; }
        bool IsWarm { get; set; }
        BreadWarmLevel? BreadWarmLevel { get; set; }
    }
}
