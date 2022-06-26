﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWebAssembly.Shared
{
    public class ShoppingBasket
    {
        public ShoppingBasket()
        {
            Customer = new Customer();
            Orders = new List<int>();
        }

        public Customer Customer { get; set; }

        public IList<int> Orders { get; set; }

        public bool HasPaid { get; set; }
    }
}
