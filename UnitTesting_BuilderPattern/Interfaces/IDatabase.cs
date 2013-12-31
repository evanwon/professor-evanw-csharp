namespace UnitTesting_BuilderPattern.Interfaces
{
    public interface IDatabase
    {
        int ChargeUserForProduct(int userId, string productCode);
        bool IsDatabaseOnline();
        void SaveTransaction(int result);
    }
}