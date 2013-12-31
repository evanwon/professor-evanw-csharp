using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Objects
{
    class MainWithInjection
    {
        public IUser User { get; set; }
        public IProduct Product { get; set; }
        public IDatabase Database { get; set; }

        public MainWithInjection()
        {
            User = new User();
            Product = new Product();
            Database = new Database("myDatabase");
        }

        public bool DoStuff()
        {
            if (!Database.IsDatabaseOnline())
            {
                return false;
            }

            var result = Database.ChargeUserForProduct(User.Id, Product.Code);

            Database.SaveTransaction(result);

            return true;
        }
    }
}
