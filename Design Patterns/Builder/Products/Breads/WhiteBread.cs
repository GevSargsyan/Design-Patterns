using Builder.Products.Product;

namespace Builder.Products.Breads
{
    internal class WhiteBread : BreadBase
    {
        public WhiteBread(bool isWarm,BreadWarmLevel warmLevel, ProductQuality quality) 
            : base("White", isWarm, warmLevel, PriceConstants.WhiteBread, nameof(WhiteBread), quality)
        {
        }
    }
}
