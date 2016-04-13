using FibonacciDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void GetNthFibonacciTest()
        {
            CalculationHelper calchelper = new CalculationHelper();

            int actual = int.MinValue;
            int expected = int.MinValue;

            //Test a basic run of the function
            actual = calchelper.CalculateFibonacci(3);
            expected = 3;
            Assert.AreEqual(expected, actual);

            //Test past the 1,1,2 range to test the interation is working correctly
            actual = calchelper.CalculateFibonacci(7);
            expected = 21;
            Assert.AreEqual(expected, actual);

            //Test required functionality
            actual = calchelper.CalculateFibonacci(10);
            expected = 89;
            Assert.AreEqual(expected, actual);

            //Test required functionality
            actual = calchelper.CalculateFibonacci(40);
            expected = 165580141;
            Assert.AreEqual(expected, actual);

            //Test bottom end case
            actual = calchelper.CalculateFibonacci(0);
            expected = 1;
            Assert.AreEqual(expected, actual);

            //Test top end edge case
            actual = calchelper.CalculateFibonacci(45);
            expected = 1836311903;
            Assert.AreEqual(expected, actual);

            //Test that we throw an exception if we will overflow the int
            try
            {
                actual = calchelper.CalculateFibonacci(46);
            }
            catch (OverflowException e)
            {
                Assert.IsNotNull(e);
            }

            //Test that we throw an exception if we try to calculate a negative position
            try
            {
                actual = calchelper.CalculateFibonacci(-1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.IsNotNull(e);
            }

            //If some other exception type is thrown let it break the tests.  We will want to know about it.
        }

        /// <summary>
        /// This tests that we are generating a 1 based list for the Fibonacci Sequence and compares the first 10 values
        /// to make sure our Fibonacci list is generating accurately.
        /// </summary>
        [TestMethod]
        public void GetFibonacciListTest()
        {
            CalculationHelper calchelper = new CalculationHelper();

            List<int> fibs = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                fibs.Add(calchelper.CalculateFibonacci(i));
            }
            string expected = "1,1,2,3,5,8,13,21,34,55";
            string actual = string.Join(",", fibs);
            Assert.AreEqual(expected, actual);
        }
    }
}