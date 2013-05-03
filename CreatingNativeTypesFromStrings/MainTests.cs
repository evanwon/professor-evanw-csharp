using System;
using System.Diagnostics;

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
        [ExpectedException(typeof(System.FormatException))]
        public void CreateIntFromDatabase_ValueIsNotAnInt_ThrowsException()
        {
            Type typeFromDatabase = Type.GetType("System.Int32");
            object valueFromDatabase = "Hello world!";

            // This should fail, and if we need additional information, we know that we were expecting
            // a System.Int32 from 'typeFromDatabase', so we can tell the user we didn't receive it
            try
            {
                dynamic convertedToBuiltInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

                // If we make it this far, something went wrong. An exception should have occurred.
                Assert.Fail();
            }
            catch (Exception ex)
            {
                // Let's say we want to tell the user what happened. We already know the expected type.
                Assert.Inconclusive("Data conversion error. Expected type ({0}).\n\n{1}", typeFromDatabase, ex);
            }
        }

        [TestMethod]
        public void CreateStringFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.String");
            object valueFromDatabase = "Hello world!";

            dynamic convertedToBuiltInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuiltInType is string);
        }

        [TestMethod]
        public void CreateDoubleFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.Double");
            object valueFromDatabase = "1.21";

            dynamic convertedToBuiltInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuiltInType is double);
        }

        [TestMethod]
        public void CreateBoolFromDatabase()
        {
            Type typeFromDatabase = Type.GetType("System.Boolean");
            object valueFromDatabase = "True";

            dynamic convertedToBuiltInType = Convert.ChangeType(valueFromDatabase, typeFromDatabase);

            Assert.IsTrue(convertedToBuiltInType is bool);
        }
    }
}
