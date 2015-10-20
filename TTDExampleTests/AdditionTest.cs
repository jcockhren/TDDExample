using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExample; // This is so we can see the 'Addition' class

namespace TTDExampleTests
{
    [TestClass]
    public class AdditionTest
    { 
        // Bootstrapping test
        [TestMethod]
        public void TestCanCreateAdditionInstance()
        {
            Addition operation_class = new Addition();
        }

        [TestMethod]
        public void TestCanAddTwoIntegers()
        {
            int input1 = 1;
            int input2 = 2;
            int expected = 3;
            Addition operation_class = new Addition();
            Assert.AreEqual(expected, operation_class.Add(input1, input2)); // "Add" must be defined.
        }

        [TestMethod]
        public void CanAddTwoNegativeNumbers()
        {
            int input1 = -1;
            int input2 = -4;
            int expected = -5;
            Addition operation_class = new Addition();
            Assert.AreEqual(expected, operation_class.Add(input1, input2));
        }

        [TestMethod] // Notes on how the Add method works.
        public void CanNotAddAnIntegerToAString()
        {
            // Ahh. The Add method can't accept string as input.
            int input1 = -1;
            string input2 = "0"; 
            int expected = -5;
            Addition operation_class = new Addition();
            //Assert.AreEqual(expected, operation_class.Add(input1, input2));
        }

        [TestMethod]
        public void CanAddTwoStringsGoodInput()
        {
            string input1 = "2";
            string input2 = "1";
            int expected = 3;
            Addition operation_class = new Addition();
            Assert.AreEqual(expected, operation_class.AddStrings(input1, input2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddTwoStringsBadInput()
        {
            string input1 = "1";
            string input2 = "kjwjrjkrjkerjk";
            Addition operation_class = new Addition();
            operation_class.AddStrings(input1,input2); // This is not an Assert
        }
    }
}
