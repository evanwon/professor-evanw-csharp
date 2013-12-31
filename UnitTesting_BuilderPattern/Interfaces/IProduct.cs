namespace UnitTesting_BuilderPattern.Interfaces
{
    public interface IProduct
    {
        string BrandName { get; }
        string Code { get; }
        decimal PriceInDollars { get; }
    }
}