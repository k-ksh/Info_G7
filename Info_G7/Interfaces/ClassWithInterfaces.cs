using Info_G7.OOP;
using System;

namespace Info_G7.Interfaces
{
    class ClassWithInterfaces : Horse, IFirstInterface, ISecondInterface
    {
        public void DoSomethingInFirstInterface()
        {
            Console.WriteLine("Action from IFirstInterface.");
        }

        public void DoSomethingInSecondInterface()
        {
            Console.WriteLine("Action from ISecondInterface.");
        }
    }
}
