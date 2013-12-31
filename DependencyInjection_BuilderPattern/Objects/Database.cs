using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Objects
{
    public class Database : IDatabase
    {
        string DatabaseName { get; set; }

        public Database(string databaseName)
        {
            DatabaseName = databaseName;
        }

        public int ChargeUserForProduct(int userId, string productCode)
        {
            return 42;
        }

        public bool IsDatabaseOnline()
        {
            return true;
        }

        public void SaveTransaction(int result)
        {
            
        }
    }
}
