using Builder.Products.Product;

namespace Builder.Products.Vegetables
{
    internal interface IVegetable : IProduct
    {
        string? VegetableType { get; set; }
    }
}
