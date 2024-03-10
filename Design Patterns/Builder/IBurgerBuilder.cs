using Builder.Products.Breads;
using Builder.Products.Cheeses;
using Builder.Products.Meats;
using Builder.Products.Product;
using Builder.Products.Sauces;
using Builder.Products.Vegetables;
using System.Text;

namespace Builder
{
    internal interface IBurgerBuilder
    {
        StringBuilder Report { get; set; }
        IBurgerBuilder BuildBread(IBread bread);
        IBurgerBuilder BuildSauce(ISauce sauce);
        IBurgerBuilder BuildVegetable(IVegetable vegetable);
        IBurgerBuilder BuildMeat(IMeat meat);
        IBurgerBuilder BuildCheese(ICheese cheese);
        Burger GetBurger();
        void ProductPriceSum(IProduct product);
        void ResetBuilder();
    }
}