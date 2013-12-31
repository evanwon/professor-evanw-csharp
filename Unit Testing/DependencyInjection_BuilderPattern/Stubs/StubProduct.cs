using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Stubs
{
    class StubProduct : IProduct
    {
        public string StubBrandName { get; set; }
        public string BrandName { get { return StubBrandName; } }

        public string StubCode { get; set; }
        public string Code { get { return StubCode; } }

        public decimal StubPriceInDollars { get; set; }
        public decimal PriceInDollars { get { return StubPriceInDollars; } }
    }
}
