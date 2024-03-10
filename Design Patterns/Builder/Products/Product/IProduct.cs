namespace Builder.Products.Product
{
    internal interface IProduct
    {
        string? Name { get; protected set; }
        string? Type { get; protected set; }
        decimal Price { get; protected set; }
        ProductQuality ProductQuality { get; protected set; }
        decimal GetPrice();
    }
}
