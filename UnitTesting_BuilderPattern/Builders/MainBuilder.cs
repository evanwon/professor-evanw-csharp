using UnitTesting_BuilderPattern.Objects;
using UnitTesting_BuilderPattern.Stubs;

namespace UnitTesting_BuilderPattern.Builders
{
    class MainBuilder
    {
        private MainWithInjection Main { get; set; }

        public static MainBuilder DefaultBuilder()
        {
            return new MainBuilder();
        }

        public MainBuilder()
        {
            // This is the default builder. Inject stubs at this point to make sure developers
            // never hit production systems. Builder methods can be called to make this object more functional.

            Main = new MainWithInjection()
            {
                Database = new StubDatabase(),
                Product = new StubProduct(),
                User = new StubUser()
            };
        }

        public MainWithInjection Build()
        {
            return Main;
        }

        public MainBuilder NormalUser()
        {
            var user = new StubUser()
            {
                StubId = 1,
                StubName = "Happy McStubberson",
                StubOccupation = "Software Test Engineer",
                StubAccountBalance = 200.00m,
                StubIsAccountOverdrawn = false
            };

            Main.User = user;

            return this;
        }

        public MainBuilder UserWithOverdrawnAccount()
        {
            var user = new StubUser()
            {
                StubId = 20,
                StubName = "Sad McStubberson",
                StubOccupation = "Unemployed",
                StubAccountBalance = -340.00m,
                StubIsAccountOverdrawn = true
            };

            Main.User = user;

            return this;
        }

        public MainBuilder UserWithLotsOfMoney()
        {
            var user = new StubUser()
            {
                StubId = 20,
                StubName = "Galt McStubberson",
                StubOccupation = "Tycoon",
                StubAccountBalance = 1000000.00m,
                StubIsAccountOverdrawn = false
            };

            Main.User = user;

            return this;
        }

        public MainBuilder NullProduct()
        {
            Main.Product = null;

            return this;
        }

        public MainBuilder DatabaseOnline()
        {
            var database = new StubDatabase()
            {
                StubIsDatabaseOnline = true,
                StubTransactionId = 1
            };

            Main.Database = database;

            return this;
        }

        public MainBuilder DatabaseOffline()
        {
            var database = new StubDatabase()
            {
                StubIsDatabaseOnline = false,
                StubTransactionId = -1
            };

            Main.Database = database;

            return this;
        }

        public MainBuilder NormalProduct()
        {
            var product = new StubProduct()
            {
                StubBrandName = "Stub Brand",
                StubCode = "12345",
                StubPriceInDollars = 20.00m
            };

            Main.Product = product;

            return this;
        }

        public MainBuilder FreeProduct()
        {
            var product = new StubProduct()
            {
                StubBrandName = "Free Brand",
                StubCode = "5678",
                StubPriceInDollars = 0.00m
            };

            Main.Product = product;

            return this;
        }

        public MainBuilder ExpensiveProduct()
        {
            var product = new StubProduct()
            {
                StubBrandName = "Rich Brand",
                StubCode = "12345",
                StubPriceInDollars = 1000.00m
            };

            Main.Product = product;

            return this;
        }
    }
}
