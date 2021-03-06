using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte(int discount) : base(discount)
        {
        }

        public int mlMilk()
        {
            return 200;
        }

        public override string Name()
        {
            return "Latte";
        }

        public override int price()
        {
            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
