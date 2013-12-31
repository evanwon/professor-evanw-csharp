using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Objects
{
    public class Product : IProduct
    {
        public string BrandName
        {
            get { return "Widget"; }
        }

        public string Code
        {
            get { return "12345-1234-1234"; }
        }

        public decimal PriceInDollars
        {
            get { return 29.95m; }
        }
    }
}
