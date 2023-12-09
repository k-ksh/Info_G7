using System;

namespace Info_G7.CommonExamples
{
    class StaticKeywordTesting
    {
        static StaticKeywordTesting()
        {
        }

        public StaticKeywordTesting()
        {
        }

        public static int staticInt = 5;

        public int nonStaticInt = 2;

        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine(nonStaticInt * staticInt);
        }
    }
}
