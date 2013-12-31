using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_BuilderPattern.Builders;

namespace UnitTesting_BuilderPattern.Tests
{
    [TestClass]
    public class MainTestWithBuilder
    {
        [TestMethod]
        public void TestMethod_EverythingOk_ReturnsTrue()
        {
            // 1. ARRANGE 
            var main = MainBuilder.DefaultBuilder()
                .DatabaseOnline()
                .NormalProduct()
                .NormalUser()
                .Build();

            // 2. ACT
            var result = main.DoStuff();

            // 3. ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_DatabaseOffline_ReturnsFalse()
        {
            // 1. ARRANGE 
            var main = MainBuilder.DefaultBuilder()
                .DatabaseOffline()
                .NormalUser()
                .NormalProduct()
                .Build();

            // 2. ACT
            var result = main.DoStuff();

            // 3. ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_UserAccountIsOverdrawn_ReturnsFalse()
        {
            // 1. ARRANGE 
            var main = MainBuilder.DefaultBuilder()
                .UserWithOverdrawnAccount()
                .DatabaseOnline()
                .NormalProduct()
                .Build();

            // 2. ACT
            var result = main.DoStuff();

            // 3. ASSERT
            Assert.IsFalse(result);
        }
    }
}
