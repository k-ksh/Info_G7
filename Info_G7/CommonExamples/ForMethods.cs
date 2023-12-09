using Info_G7.Interfaces;
using System;

namespace Info_G7.CommonExamples
{
    class ForMethods
    {
        public void MethodWithoutReturn()
        {
            Console.WriteLine("Method Without Return");
        }

        public int MethodWithReturn(out bool additionalReturn)
        {
            Console.WriteLine("Method With Return");
            additionalReturn = true;
            return 0;
        }

        public static void WorkWithParameters(int firstNumber = 11, int secondNumber = 22)
        {
            Console.WriteLine($"First number is {firstNumber}.");
            Console.WriteLine($"Second number is {secondNumber}.");
        }

        public void CreateAndSendReport()
        {
            CreateReport();
            SendReport();
        }

        public void CreateReport() { }

        public void SendReport() { }

        public int ReturnWithIfElse(int a, int b)
        {
            if (a > b)
            {
                return 6;
            }
            else if (a < b)
            {
                return 100;
            }
            else
            {
                return -4;
            }
        }

        #region Overloading

        public void Test() { }

        public void Test(int a) { }

        public void Test(string a) { }

        public void Test(int a, string b) { }

        public void Test(string a, int b) { }

        #endregion

        public static int? GetLatestNumberInArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty");
                int? result = null;
                return result;
            }
            return array[array.Length - 1];
        }

        public static void TestInterface(IFirstInterface firstInterface)
        {
            firstInterface.DoSomethingInFirstInterface();
        }
    }
}
