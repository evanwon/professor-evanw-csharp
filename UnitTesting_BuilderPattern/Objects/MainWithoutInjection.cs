using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_BuilderPattern.Objects
{
    public class MainWithoutInjection
    {
        public bool DoStuff()
        {
            var user = new User();

            var product = new Product();

            var database = new Database("myDatabase");

            if (!database.IsDatabaseOnline())
            {
                return false;
            }

            var transactionId = database.ChargeUserForProduct(user.Id, product.Code);

            database.SaveTransaction(transactionId);

            return true;
        }
    }
}
