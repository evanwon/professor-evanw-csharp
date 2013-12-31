using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var carBuilder = new CarBuilder();

            var car = carBuilder
                .Blue()
                .ToyotaPrius()
                .FastCar()
                .Build();

            Assert.Equals("Blue", car.Color);
        }
    }
}
