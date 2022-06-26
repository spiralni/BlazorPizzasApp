﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlaceWebAssembly.Shared
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            Id = id;
            Name = name;
            Price = price;
            Spiciness = spiciness;
        }

        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
    }
}
