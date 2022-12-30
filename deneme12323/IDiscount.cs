using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme12323
{
    public interface IDiscount
    {
        double Discount { get; set; }
        double GetDiscountedPrice();
    }
}