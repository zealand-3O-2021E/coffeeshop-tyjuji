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
                new BlackCoffee(),
                new Cortado(),
                new Latte()

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("A " + coffee.Name() + " has a strength of " + coffee.Strength() + ", and costs " + coffee.price() + ".");
            }


        }
    }
}
