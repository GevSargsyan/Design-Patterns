namespace Builder.Products.Product
{
    internal abstract class ProductBase : IProduct
    {
        protected ProductBase(decimal price, string name, ProductQuality quality)
        {
            Price = price;
            Name = name;
            ProductQuality = quality;
        }
        public decimal Price { get; set; }
        public string? Name { get; set; }
        public ProductQuality ProductQuality { get; set; }
        public virtual decimal GetPrice() => Price * (int)ProductQuality;
        public abstract string? Type { get; set; }
    }
}
