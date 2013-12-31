using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Objects
{
    public class User : IUser
    {
        public int Id
        {
            get { return 1; }
        }

        public string Name
        {
            get { return "Evan Wondrasek"; }
        }

        public string Occupation
        {
            get { return "Paleontologist"; }
        }

        public decimal GetAccountBalance()
        {
            return 100.00m;
        }

        public bool IsAccountOverdrawn()
        {
            throw new NotImplementedException();
        }
    }
}
