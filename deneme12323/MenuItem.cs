using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme12323
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        
        public abstract string GetDescription();
    }

}
