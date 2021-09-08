using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(int discount) : base(discount)
        {
        }

        public int mlMilk()
        {
            return 40;
        }

        public override string Name()
        {
            return "Cortado";
        }

        public override int price()
        {
            return 25 - Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
