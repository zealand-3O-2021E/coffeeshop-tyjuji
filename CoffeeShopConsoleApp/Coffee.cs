using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public Coffee(int discount)
        {
            if(discount > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(discount), "Discount is too large.");
            }
            Discount = discount;
        }
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20 - Discount;
        }

        public int Discount { get; set; }

        public abstract string Name();

        public abstract string Strength();

    }
}
