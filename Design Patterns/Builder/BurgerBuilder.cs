using Builder.Products.Breads;
using Builder.Products.Cheeses;
using Builder.Products.Meats;
using Builder.Products.Product;
using Builder.Products.Sauces;
using Builder.Products.Vegetables;
using System.Text;

namespace Builder
{
    internal class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public decimal Price { get; private set; }
        public BurgerBuilder()
        {
            Report = new StringBuilder();
            _burger = new();
        }

        public StringBuilder Report { get; set; }

        public IBurgerBuilder BuildBread(IBread bread)
        {
            _burger.Bread = bread;
            Report.AppendLine($"{bread.Name} - {bread.BreadType} - {(bread.IsWarm ? bread.BreadWarmLevel : string.Empty)}");
            ProductPriceSum(bread);
            return this;
        }

        public IBurgerBuilder BuildCheese(ICheese cheese)
        {
            _burger.Cheeses.Add(cheese);
            Report.AppendLine($"{cheese.Name} - {cheese.CheeseType} - {cheese.MeltLevel}");
            ProductPriceSum(cheese);
            return this;
        }
        public IBurgerBuilder BuildMeat(IMeat meat)
        {
            _burger.Meats.Add(meat);
            Report.AppendLine($"{meat.Name} - {meat.MeatType}");
            ProductPriceSum(meat);
            return this;
        }

        public IBurgerBuilder BuildSauce(ISauce sauce)
        {
            _burger.Sauces.Add(sauce);
            Report.AppendLine($"{sauce.Name} - {sauce.SauceType}");
            ProductPriceSum(sauce);
            return this;
        }

        public IBurgerBuilder BuildVegetable(IVegetable vegetable)
        {
            _burger.Vegetables.Add(vegetable);
            Report.AppendLine($"{vegetable.Name} - {vegetable.VegetableType}");
            ProductPriceSum(vegetable);
            return this;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;
            burger.Price = Price;
            return burger;
        }

        public void ProductPriceSum(IProduct product)
        {
            decimal productPrice = product.GetPrice();
            Report.AppendLine($" - Product Quality - {product.ProductQuality} - {product.Name} Price {product.Price} => {(int)product.ProductQuality} * {product.Price} = {productPrice}");
            Price += productPrice;
        }

        public void ResetBuilder()
        {
            _burger = new();
            Report.Clear();
            Price = 0;
        }

    }
}