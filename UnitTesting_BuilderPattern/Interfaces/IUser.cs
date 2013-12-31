namespace UnitTesting_BuilderPattern.Interfaces
{
    public interface IUser
    {
        int Id { get; }
        string Name { get; }
        string Occupation { get; }

        decimal GetAccountBalance();
        bool IsAccountOverdrawn();
    }
}