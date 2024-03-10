using Builder.Products.Breads;
using Builder.Products.Cheeses;
using Builder.Products.Meats;
using Builder.Products.Product;
using Builder.Products.Sauces;
using Builder.Products.Vegetables;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurgerBuilder builder = new BurgerBuilder();

            builder
                .BuildBread(new WhiteBread(true, BreadWarmLevel.LowWarmed, ProductQuality.Medium))
                .BuildMeat(new AngusMeat(DonenessType.WellDone, ProductQuality.High))
                .BuildMeat(new ChickenMeat(DonenessType.WellDone, ProductQuality.High, isSpicy:true))
                .BuildVegetable(new Cucumber(ProductQuality.High))
                .BuildVegetable(new Onion(ProductQuality.High))
                .BuildCheese(new YellowCheese(ProductQuality.Medium, MeltLevel.Medium))
                .BuildCheese(new WhiteCheese(ProductQuality.Medium, MeltLevel.Medium))
                .BuildSauce(new WhiteSauce(true, ProductQuality.Low));

           var burger = builder.GetBurger();
            Console.WriteLine(builder.Report);
            Console.Write("Total Price - ");
            Console.WriteLine(burger.Price);

            builder.ResetBuilder();

            builder.BuildBread(new BlackBread(false, BreadWarmLevel.LowWarmed,ProductQuality.Medium))
                .BuildMeat(new ChickenMeat(DonenessType.WellDone,ProductQuality.High, isSpicy:true));



            burger = builder.GetBurger();
            Console.WriteLine(builder.Report);
            Console.Write("Total Price - ");
            Console.WriteLine(burger.Price);
        }
    }
}
