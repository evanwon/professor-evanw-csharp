using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_BuilderPattern.Builders;
using UnitTesting_BuilderPattern.Objects;
using UnitTesting_BuilderPattern.Stubs;

namespace UnitTesting_BuilderPattern.Tests
{
    [TestClass]
    public class MainTestWithBuilder
    {
        [TestMethod]
        public void TestMethod_EverythingOk_ReturnsTrue()
        {
            // 1. ARRANGE 

            // 1a. Set up objects to inject
            var database = new StubDatabase
            {
                StubTransactionId = -1,
                StubIsDatabaseOnline = true
            };

            var product = new StubProduct()
            {
                StubBrandName = "Stub Brand",
                StubCode = "12345",
                StubPriceInDollars = 12.00m
            };

            var user = new StubUser()
            {
                StubName = "Stubby McStubberson",
                StubOccupation = "Software Test Engineer",
                StubAccountBalance = 200.00m,
                StubIsAccountOverdrawn = false
            };

            // 1b. Inject 
            var main = new MainWithInjection()
            {
                Database = database,
                Product = product,
                User = user
            };

            // 2. ACT
            var result = main.DoStuff();

            // 3. ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_DatabaseOffline_ReturnsFalse()
        {
            // 1. ARRANGE 

            // 1a. Set up objects to inject
            var database = new StubDatabase
            {
                StubTransactionId = -1,
                StubIsDatabaseOnline = false
            };

            var product = new StubProduct()
            {
                StubBrandName = "Stub Brand",
                StubCode = "12345",
                StubPriceInDollars = 12.00m
            };

            var user = new StubUser()
            {
                StubName = "Stubby McStubberson",
                StubOccupation = "Software Test Engineer",
                StubAccountBalance = 250.00m,
                StubIsAccountOverdrawn = false
            };

            // 1b. Inject 
            var main = new MainWithInjection()
            {
                Database = database,
                Product = product,
                User = user
            };

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
