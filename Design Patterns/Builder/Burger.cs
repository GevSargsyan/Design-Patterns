using Builder.Products.Breads;
using Builder.Products.Cheeses;
using Builder.Products.Meats;
using Builder.Products.Sauces;
using Builder.Products.Vegetables;

namespace Builder
{
    internal class Burger
    {
        public decimal Price { get; set; }
        public IBread? Bread { get; set; }
        public List<IMeat>? Meats { get; set; } = [];
        public List<ISauce>? Sauces { get; set; } = [];
        public List<ICheese>? Cheeses { get; set; } = [];
        public List<IVegetable>? Vegetables { get; set; } = [];
    }
}
