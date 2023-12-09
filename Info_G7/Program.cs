using Info_G7.CommonExamples;
using Info_G7.Extentions;
using Info_G7.HW;
using Info_G7.Interfaces;
using Info_G7.OOP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Info_G7
{
    class Program
    {
        static int myInt = 5;

        static void Main(string[] args)
        {
            #region Data types

            // Bad example
            int a1 = 5, b1 = -2, c1 = 0, d1 = 99;

            Program.myInt = 56;

            int myInt = 5;
            //Console.WriteLine(myInt);

            string myString = "My string";
            bool myBool = true;
            char myChar = 'Q';

            double myDouble = 3.45;
            float myFloat = 4.45f;
            decimal myDecimal = 2345634234234242342345235M;

            var test = 3M;

            int intForCasting = 50;
            byte byteForCasting = 4;

            //intForCasting = (int)byteForCasting;
            //byteForCasting = (byte)intForCasting;

            //Console.WriteLine(byteForCasting);
            //Console.WriteLine(myInt);
            //Console.WriteLine();
            //Console.WriteLine(myString);

            #endregion

            #region Methods

            int firstNumber = 0;
            int secondNumber = 3;

            //ForMethods.WorkWithParameters();
            //ForMethods.WorkWithParameters(2, -3);

            //ForMethods.WorkWithParameters(firstNumber, secondNumber);
            //ForMethods.WorkWithParameters(31, 34);
            //ForMethods.WorkWithParameters(2, 0);

            //firstNumber = 10;
            //secondNumber = 36;
            //ForMethods.WorkWithParameters(firstNumber, secondNumber);

            #endregion

            #region OOP

            Parent parent = new Parent();
            Parent parent1 = new Parent();
            Parent parent2 = new Parent("Real name");

            //Console.WriteLine(parent.ToString());

            Child child = new Child();
            //child.WorkWithProtectedVariable();

            //string name = parent.name;

            //Console.WriteLine(parent.name);
            //Console.WriteLine(parent1.name);
            //Console.WriteLine(parent2.name);

            //parent.SaySomething();

            Pet pet = new Pet();

            //Console.WriteLine(pet._name);            
            //pet.PrintName();

            // Создаём экземпляр класса Horse и вызываем методы
            Horse horse = new Horse();
            //Console.WriteLine("Horse says: " + horse.Speak());
            //Console.WriteLine("Horse is: " + horse.GetColor());

            // Создаём экземпляр класса Zebra и вызываем методы
            Zebra zebra = new Zebra();
            //Console.WriteLine("Zebra says: " + zebra.Speak());
            //Console.WriteLine("Zebra is: " + zebra.GetColor());

            // Приводим класс Zebra к Horse и вызываем методы
            //Console.WriteLine("Zebra says: " + ((Horse)zebra).Speak());
            //Console.WriteLine("Horse is: " + ((Horse)zebra).GetColor());

            //InvokeGetColor(horse);
            //InvokeGetColor(zebra);

            #endregion

            #region Overloading

            ForMethods forMethods = new ForMethods();

            forMethods.Test();
            forMethods.Test(5);
            forMethods.Test("test");
            forMethods.Test(3, "test1");
            forMethods.Test("test2", 89);

            #endregion

            #region Static

            var staticKeywordTesting1 = new StaticKeywordTesting();
            var staticKeywordTesting2 = new StaticKeywordTesting();

            //staticKeywordTesting1.NonStaticMethod();
            staticKeywordTesting2.nonStaticInt = 3;
            //staticKeywordTesting2.NonStaticMethod();

            //var staticIntInMain = StaticKeywordTesting.staticInt;
            //Console.WriteLine(staticIntInMain);
            //StaticKeywordTesting.StaticMethod();

            #endregion

            #region Properties

            Properties properties = new Properties();

            //Console.WriteLine(properties.MyProperty);

            //properties.MyProperty = 9;

            var propValue = properties.MyProperty;

            //Console.WriteLine(properties.GetPrivateInt());

            properties.CustomProperty = 10;

            #endregion

            #region If-else

            bool condition = 4 < 0;

            if (condition)
            {
                //Console.WriteLine("If with true condition.");
                //Console.WriteLine("If with true condition second line.");
            }
            else
            {
                //Console.WriteLine("Else section.");
            }

            int a = 5;
            int b = 7;

            if (a > b)
            {
                //Console.WriteLine($"The biggest number of '{a}' and '{b}' is '{a}'.");
            }
            else if (a < b)
            {
                //Console.WriteLine($"The biggest number of '{a}' and '{b}' is '{b}'.");
            }
            else
            {
                //Console.WriteLine($"Numbers '{a}' and '{b}' are equal.");
            }

            var result = a > b ? "a > b" : "a < b";

            //Console.WriteLine(result);

            #endregion

            #region Switch

            string str1 = "str1";
            string str2 = "str2";
            string str3 = "efssef";

            switch (str3)
            {
                case "str1":
                    Console.WriteLine("String is str1");
                    break;
                case "str2":
                    Console.WriteLine("String is str2");
                    break;
                default:
                    Console.WriteLine("Default behavior");
                    break;
            }


            #endregion

            int forLogicalOperators1 = 3;
            int forLogicalOperators2 = 8;

            if (forLogicalOperators1 > 0 || forLogicalOperators2 > 0)
            {
                //Console.WriteLine($"Both numbers '{forLogicalOperators1}' and " +
                //    $"'{forLogicalOperators2}' are greater than zero.");
            }

            #region Loops

            bool conditionForWhile = true;
            int counterForWhile = 0;

            //while (counterForWhile < 5)
            //{
            //    Console.WriteLine(counterForWhile);
            //    counterForWhile++;
            //}

            //do
            //{
            //    Console.WriteLine(counterForWhile);
            //    counterForWhile++;
            //} while (counterForWhile < 5);

            //for (int i = 10; i > 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (string i = "A"; i != "AAAAA"; i = i + "A")
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Arrays

            int[] numbers = new int[5];

            numbers[0] = 23;
            numbers[1] = -3;
            numbers[2] = 0;
            numbers[3] = 10;
            numbers[4] = 11;

            //Console.WriteLine(numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine(numbers[i]);
            }

            int[] numbers1 = new int[7] { 23, 43, 2, 66, 23, 5, 1 };

            bool[] logicalValues = { true, true, false, false, false };

            // Two-dimensional array of strings.
            string[,] names = new string[3, 4]
            {
                { "John", "Jack", "Ron", "Hugh" },
                { "Aaron", "Abbey", "Adam", "Addy" },
                { "Becca", "Swati1", "Swati2", "Swati3" }
            };

            //Console.WriteLine(names[1, 1]);

            // Bad example
            int[] numbers2 = new int[3];
            // Some code noy related to array
            numbers2[0] = 23;
            // ...
            // ...
            // ...

            var array = new int[3] { 11, 22, 33 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //    array[i] = array[i] * 100; 
            //}

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            var arrayEmpty = new int[0] {  };
            int? latestNumber = ForMethods.GetLatestNumberInArray(arrayEmpty);
            //Console.WriteLine($"Result is '{latestNumber}'.");

            #endregion

            #region Extensions

            string stringForExtension = "ABCD";

            //Console.WriteLine(stringForExtension.ToLower());
            //Console.WriteLine(stringForExtension.Length);

            var resultString = StringExtentions.MakeDoubleString(stringForExtension);
            //Console.WriteLine(resultString);

            resultString = stringForExtension.MakeDoubleString();
            //Console.WriteLine(resultString);

            #endregion

            #region Collections

            List<int> listInt = new List<int>();

            listInt.Add(7);
            listInt.Add(1);
            listInt.Add(8);
            listInt.Add(9);
            listInt.Add(10);
            
            listInt.Clear();

            //Console.WriteLine(listInt.Count);
            //Console.WriteLine(listInt.Capacity);

            //Console.WriteLine(listInt[0]);

            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add("First Key", 8);

            Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "Key 1", 23 },
                { "Key 2", 11 },
                { "Key 3", 11 }
            };

            Dictionary<int, int[]> dict3 = new Dictionary<int, int[]>();
            dict3.Add(1, new int[] { 3, 4, 5 });

            //Console.WriteLine(dict1["First Key"]);
            //Console.WriteLine(dict2.TryGetValue("Key 1", out int resultFromDict));
            //Console.WriteLine(resultFromDict);

            var keys = dict2.Keys;
            var values = dict2.Values;

            foreach (var key in keys)
            {
                if (key == "Key 1")
                {
                    //Console.WriteLine(key);
                }
            }

            foreach (var val in values)
            {
                //Console.WriteLine(val);
            }

            foreach (var pair in dict2)
            {
                //Console.WriteLine(pair.Key);
                //Console.WriteLine(pair.Value);
            }

            #endregion

            var colors = new List<string> { "white", "black" };
            Ball ball = new Ball(colors);

            foreach (var color in colors)
            {
                //Console.WriteLine(color);
            }

            #region LINQ

            List<int> listForLinq = new List<int>() { 0, -3, -3, 4, 8 };

            List<int> numbersLessZero = new List<int>();

            foreach (var num in listForLinq)
            {
                if (num < 0)
                {
                    numbersLessZero.Add(num);
                }
            }

            var numbersLessZeroLinq = listForLinq.Where(num => num < 0);

            foreach (var item in numbersLessZeroLinq)
            {
                //Console.WriteLine(item);
            }
            
            var resultSet =
                from num in listForLinq
                where num < 5
                select num;

            foreach (var number in resultSet)
            {
                if (number == 0)
                {
                    continue;
                }

                if (number == -3)
                {
                    break;
                }

                //Console.WriteLine(number);
            }

            IEnumerable<int> result1 = listForLinq.Where(num => num < 5);

            IEnumerable<string> result2 = listForLinq.Select(num => num.ToString());

            var result3 = listForLinq.Any(num => num == 4);
            var result4 = listForLinq.Any();            

            var result5 = listForLinq.All(num => num > 0);
           
            var result6 = listForLinq.First();
            var result7 = listForLinq.First(num => num == 4);            

            var result8 = listForLinq.FirstOrDefault();
            var result9 = listForLinq.FirstOrDefault(num => num == 4);
            
            var result10 = listForLinq.Single(num => num == 0);
            var result11 = listForLinq.SingleOrDefault(num => num == 5);

            int[] result12 = listForLinq.Where(num => num < 5).ToArray();

            #endregion

            #region Exceptions

            int a11 = 5;
            int zeroNumber = 0;            

            try
            {
                //Console.WriteLine(a11 / zeroNumber);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Catch area.");

                //Console.WriteLine(e.Message);

                //throw;
            }

            //throw new Exception("Custom error message.");

            int[] arrayForException = new int[5] { 43, 2, 23, 5, 1 };

            try
            {
                var number = arrayForException[6];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

            #endregion

            #region Interfaces

            var classWithInterfaces = new ClassWithInterfaces();

            ForMethods.TestInterface(classWithInterfaces);

            #endregion

            AbstractClass.AbsractMethod();

            Console.ReadKey();
        }

        public static void InvokeGetColor(Horse horse)
        {
            Console.WriteLine(horse.GetColor());
        }

        public static void InvokeGetColor(Zebra zebra)
        {
            Console.WriteLine(zebra.GetColor());
        }
    }
}
