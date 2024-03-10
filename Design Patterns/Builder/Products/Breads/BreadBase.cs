using Builder.Products.Product;

namespace Builder.Products.Breads
{
    internal class BreadBase : ProductBase, IBread
    {
        public BreadBase(string breadType,bool isWarm,BreadWarmLevel warmLevel,decimal price, string name, ProductQuality quality) 
            : base(price, name, quality)
        {
            BreadType = breadType;
            IsWarm = isWarm;
            BreadWarmLevel = warmLevel;
        }

        public string? BreadType { get; set; }
        public bool IsWarm { get; set; }
        public override string? Type { get; set; } = "Bread";
        public BreadWarmLevel? BreadWarmLevel { get; set; }
    }
}
