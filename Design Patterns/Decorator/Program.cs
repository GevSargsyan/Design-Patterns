using Decorator.Implementations;
using Decorator.Models;
using Decorator.PaymentComissions;
using Decorator.ShippingCosts;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayInitialExample();
            //DisplayShippingCostsExample();
            //DisplayDoubleDecoratorCostsExample();
            //DisplayComissionDecoratorExample();
            DisplayDoubleComissionDecoratorExample();
            Console.ReadLine();
        }

        static void DisplayInitialExample()
        {
            Console.WriteLine("Example 1 - parcel without decorators");

            var package = CreatePackage();

            Console.WriteLine(package.DisplayPackageInfo());
            Console.WriteLine();
        }

        static void DisplayShippingCostsExample()
        {
            Console.WriteLine("Example 2 - decorator changes the way shipping costs are calculated");

            var package = CreatePackage();

            var postPackage = new PostShippingPackage(package);

            Console.WriteLine(postPackage.DisplayPackageInfo());
            Console.WriteLine();
        }

        static void DisplayDoubleDecoratorCostsExample()
        {
            Console.WriteLine("Example 3 - 2 decorators change the way shipping costs are calculated");

            var package = CreatePackage();

            var postPackage = new PostShippingPackage(package);
            var dhlPackage = new DhlShippingPackage(postPackage);

            Console.WriteLine(dhlPackage.DisplayPackageInfo());
            Console.WriteLine();
        }

        static void DisplayComissionDecoratorExample()
        {
            Console.WriteLine("Example 4");
            Console.WriteLine("2 decorators change the way shipping costs are calculated");
            Console.WriteLine("1 decorator changes the way payment commission is calculated");

            var package = CreatePackage();

            var postPackage = new PostShippingPackage(package);
            var dhlPackage = new DhlShippingPackage(postPackage);
            var wuComissionpackage = new WesternUnionPaymentComissionPackage(dhlPackage);

            Console.WriteLine(wuComissionpackage.DisplayPackageInfo());
            Console.WriteLine();
        }

        static void DisplayDoubleComissionDecoratorExample()
        {
            Console.WriteLine("Example 5");
            Console.WriteLine("2 decorators change the way shipping costs are calculated");
            Console.WriteLine("2 decorators change the way the payment commission is calculated");

            var package = CreatePackage();

            var postPackage = new PostShippingPackage(package);
            var dhlPackage = new DhlShippingPackage(postPackage);
            var wuComissionpackage = new WesternUnionPaymentComissionPackage(dhlPackage);
            var mgComissionpackage = new MoneyGramPaymentComissionPackage(wuComissionpackage);

            Console.WriteLine(mgComissionpackage.DisplayPackageInfo());
            Console.WriteLine();
        }


        static Package<OrderItem> CreatePackage()
        {
            var laptop = new OrderItem() { Name = "MacBook", Quantity = 1, Price = 2.999M, Weight = 3.0M };
            var iPhones = new OrderItem() { Name = "iPhone", Quantity = 2, Price = 1.499M, Weight = 0.2M };

            var package = new Package<OrderItem>();
            package.AddItem(laptop);
            package.AddItem(iPhones);

            return package;
        }
    }
}
