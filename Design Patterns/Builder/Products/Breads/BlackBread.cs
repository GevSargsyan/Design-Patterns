using Builder.Products.Product;

namespace Builder.Products.Breads
{
    internal class BlackBread : BreadBase
    {
        public BlackBread(bool isWarm, BreadWarmLevel warmLevel, ProductQuality quality)
            : base("Black", isWarm, warmLevel, PriceConstants.BlackBread, nameof(BlackBread), quality)
        {
        }
    }
}
