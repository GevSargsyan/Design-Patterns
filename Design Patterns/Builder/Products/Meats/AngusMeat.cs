using Builder.Products.Product;

namespace Builder.Products.Meats
{
    internal class AngusMeat : MeatBase
    {
        public AngusMeat(DonenessType doneness,ProductQuality quality) 
            : base(doneness,"Angus",PriceConstants.AngusMeat,nameof(AngusMeat), quality) { }
    }
}
