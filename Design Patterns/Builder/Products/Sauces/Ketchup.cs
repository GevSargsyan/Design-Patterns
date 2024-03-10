using Builder.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products.Sauces
{
    internal class Ketchup : SauceBase
    {
        public Ketchup(bool isThick, ProductQuality quality) : base("Ketchup", isThick, PriceConstants.Ketchup, nameof(Ketchup), quality)
        {
        }
    }
}
