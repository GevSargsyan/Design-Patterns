using Builder.Products.Product;

namespace Builder.Products.Vegetables
{
    internal class VegetableBase : ProductBase, IVegetable
    {
        public VegetableBase(string vegetableType,decimal price, string name, ProductQuality quality) : base(price, name, quality)
        {
            VegetableType = vegetableType;
        }

        public string? VegetableType { get; set; }
        public override string? Type { get; set; } = "Vegetable";
    }
}