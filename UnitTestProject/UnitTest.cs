using NUnit.Framework;
using System;
using System.Threading;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [OneTimeSetUp]
        public void BeforeRun()
        {
            Console.WriteLine("BeforeRun");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [SetUp]
        public void BeforeEveryTestMethod()
        {
            Console.WriteLine("SetUp");
        }

        [TearDown]
        public void AfterEveryTestMethod()
        {
            Console.WriteLine("TearDown");
        }

        [Order(2)]
        [Category("FirstTest")]
        [Category("Smoke")]
        //[Test]
        public void TestMethod1()
        {
            Console.WriteLine("TestMethod1");
            Thread.Sleep(2000);
        }

        [Order(1)]
        //[Ignore("Ignore for testing reason")]
        [Category("Regression")]
        //[Test]
        public void TestMethod2()
        {
            Console.WriteLine("TestMethod2");
        }

        //[Test]
        public void Positive_SumTwoNumbers()
        {
            // Arrange
            int firstNumber = 3;
            int secondNumber = 4;
            int expectedResult = 7;

            // Act
            int actualResult = Calculator.SumTwoNumbers(firstNumber, secondNumber);

            // Assert
            Assert.True(actualResult == expectedResult, 
                $"Actual sum '{actualResult}' of '{firstNumber}' and " +
                $"'{secondNumber}' is not equal '{expectedResult}'.");
        }

        //[Test]
        public void Negative_DivideTwoNumbers_ExpectedException()
        {
            // Arrange
            int firstNumber = 3;
            int secondNumber = 0;

            // Act
            // Assert
            Assert.Throws<DivideByZeroException>(
                () => Calculator.DivideTwoNumbers(firstNumber, secondNumber), 
                $"There is no DivideByZeroException while dividing " +
                $"{firstNumber} on {secondNumber}.");
        }

        //[Test]
        public void TestFinally()
        {
            int[] arrayForException = new int[5] { 43, 2, 23, 5, 1 };

            try
            {
                var number = arrayForException[6];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally area.");
            }
        }
    }
}
