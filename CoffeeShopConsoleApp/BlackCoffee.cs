﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public override string Name()
        {
            return "Black Coffee";
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
