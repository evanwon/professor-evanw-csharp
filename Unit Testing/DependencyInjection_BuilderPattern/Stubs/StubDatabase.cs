using System.Diagnostics;
using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Stubs
{
    class StubDatabase : IDatabase
    {
        public int StubTransactionId { get; set; }
        public int ChargeUserForProduct(int userId, string productCode)
        {
            return StubTransactionId;
        }

        public bool StubIsDatabaseOnline { get; set; }
        public bool IsDatabaseOnline()
        {
            return StubIsDatabaseOnline;
        }

        public void SaveTransaction(int result)
        {
            Debug.Print("(Stub) Saving result: " + result);
        }
    }
}
