using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme12323
{
    public class Drink : MenuItem, IDiscount
    {
        public bool Alcoholic { get; set; }
        public double Discount { get; set; }

        public Drink(string name, double price, bool alcoholic) : base(name, price)
        {
            Alcoholic = alcoholic;
        }

        
        public override string GetDescription()
        {
            string alcoholicString = Alcoholic ? " (alcoholic)" : " (non-alcoholic)";
            return $"{Name}: ${Price:F2}{alcoholicString}";
        }

    
        public double GetDiscountedPrice()
        {
            return Price - (Price * Discount);
        }
    }
}
