using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme12323
{
    public class Entree : MenuItem, IDiscount
    {
        public string[] Options { get; set; }
        public double Discount { get; set; }

        public Entree(string name, double price, string[] options) : base(name, price)
        {
            Options = options;
        }


        public override string GetDescription()
        {
            string optionsString = "";
            for (int i = 0; i < Options.Length; i++)
            {
                optionsString += $"\n  {i + 1}. {Options[i]}";
            }

            return $"{Name}: ${Price:F2}\nOptions:{optionsString}";
        }


        public double GetDiscountedPrice()
        {
            return Price - (Price * Discount);
        }
    }
}