using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreatingNativeTypesFromStrings
{
    /// <summary>
    /// This unit test project demonstrates how you can take a string/object representation of a native C# data type
    /// (from a database, for example) and conver it to a built-in C# type.
    /// </summary>
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void CreateIntFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.Int32");
            object valueFromDatabase = "100";

            dynamic convertedToBuiltInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuiltInType is int);
        }

        [TestMethod]
        public void CreateStringFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.String");
            object valueFromDatabase = "Hello world!";

            dynamic convertedToBuildInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuildInType is string);
        }

        [TestMethod]
        public void CreateDoubleFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.Double");
            object valueFromDatabase = "1.21";

            dynamic convertedToBuildInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuildInType is double);
        }

        [TestMethod]
        public void CreateBoolFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.Boolean");
            object valueFromDatabase = "True";

            dynamic convertedToBuildInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuildInType is bool);
        }
    }
}
