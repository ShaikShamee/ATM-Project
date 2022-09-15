using LogicalProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProgramTestCase
{
    [TestClass]
    public class UnitTest1
    {
        Factorial f = new Factorial();
        PrimeNumbers p = new PrimeNumbers();
        [TestMethod]
        public void Test_FactorialNumber()
        {
            
            int expected = 1;
            int actual = f.FactorialNumber(6);
            Assert.AreEqual(expected,actual);
            
        }
        [TestMethod]
        public void Test_FactorialNumber_LessThanZero()
        {
            int number = -1;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => f.FactorialNumber(number));

        }
        [TestMethod]
        public void Test_PrimeNumber()
        {
            
            bool expected = true;
            Assert.AreEqual(expected, p.PrimeNumberMethod(5));

        }

        [TestMethod]
        public  void Test_PrimeNumber_LessThanZero()
        {
            int number = -1;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => p.PrimeNumberMethod(number));

        }
    }
}
