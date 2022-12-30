using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme12323
{
    public class Dessert : MenuItem, IDiscount
    {
        public bool HasIceCream { get; set; }
        public double Discount { get; set; }
        double IDiscount.Discount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Dessert(string name, double price, bool hasIceCream) : base(name, price)
        {
            HasIceCream = hasIceCream;
        }


        public override string GetDescription()
        {
            return $"{Name}: ${Price:F2}";

        }

        double IDiscount.GetDiscountedPrice()
        {
            throw new NotImplementedException();
        }
    }
}