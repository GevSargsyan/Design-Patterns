using Builder.Products.Product;

namespace Builder.Products.Meats
{
    internal class ChickenMeat : MeatBase
    {
        public bool IsSpicy { get; set; }
        public ChickenMeat(DonenessType doneness,ProductQuality quality,bool isSpicy) 
            : base(doneness,"Chicken",PriceConstants.ChickenMeat, nameof(ChickenMeat), quality) 
        {
            IsSpicy = isSpicy;
        }

    }
}
