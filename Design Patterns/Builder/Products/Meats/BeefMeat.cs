using Builder.Products.Product;

namespace Builder.Products.Meats
{
    internal class BeefMeat : MeatBase
    {
        public BeefMeat(DonenessType doneness,ProductQuality quality) 
            : base(doneness,"Beef", PriceConstants.BeefMeat, nameof(BeefMeat), quality) { }
    }
}
