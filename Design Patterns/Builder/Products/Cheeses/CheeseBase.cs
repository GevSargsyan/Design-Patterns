using Builder.Products.Product;

namespace Builder.Products.Cheeses
{
    internal class CheeseBase : ProductBase, ICheese
    {
        public CheeseBase(MeltLevel meltlevel,string cheeseType,decimal price, string name, ProductQuality quality) : base(price, name, quality)
        {
            CheeseType = cheeseType;
            MeltLevel = meltlevel;
        }
        public override string? Type { get; set; } = "Cheese";
        public string? CheeseType { get; set; }
        public MeltLevel? MeltLevel { get; set; }
    }
}