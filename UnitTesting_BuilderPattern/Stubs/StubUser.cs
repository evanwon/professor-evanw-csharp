using UnitTesting_BuilderPattern.Interfaces;

namespace UnitTesting_BuilderPattern.Stubs
{
    class StubUser : IUser
    {
        public int StubId { get; set; }
        public int Id { get { return StubId; } }

        public string StubName { get; set; }
        public string Name { get { return StubName; } }

        public string StubOccupation { get; set; }
        public string Occupation { get { return StubOccupation; } }

        public decimal StubAccountBalance { get; set; }
        public decimal GetAccountBalance()
        {
            return StubAccountBalance;
        }

        public bool StubIsAccountOverdrawn { get; set; }
        public bool IsAccountOverdrawn()
        {
            return StubIsAccountOverdrawn;
        }
    }
}
