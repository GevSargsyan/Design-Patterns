using Builder.Products.Product;

namespace Builder.Products.Meats
{
    internal class MeatBase : ProductBase, IMeat
    {
        public MeatBase(DonenessType doneness,string meatType,decimal price,string name,ProductQuality quality) 
            : base(price,name,quality)
        {
            Doneness = doneness;
            MeatType = meatType;
        }
        public string? MeatType { get; set; }
        public DonenessType Doneness { get; set; }
        public override string? Type { get; set; } = "Meat";
    }
}
