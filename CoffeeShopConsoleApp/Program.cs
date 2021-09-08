using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(1),
                new Cortado(2),
                new Latte(3)

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("A " + coffee.Name() + " has a strength of " + coffee.Strength() +
                    ", and costs " + coffee.price() + " with a discount of " + coffee.Discount + ".");
            }

            Console.WriteLine("List of coffees with milk:");

            List<IMilk> milkList = new List<IMilk>()
            {
                new Cortado(2),
                new Latte(3)
            };

            foreach (var coffee in milkList)
            {
                Console.WriteLine("A " + ((Coffee)coffee).Name() + " contains " + coffee.mlMilk() + " mLs of milk.");
            }



        }
    }
}
