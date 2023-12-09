using System;

namespace Info_G7.OOP
{
    public class ChildOfAbstractClass : AbstractClass
    {
        public override void AbsractMethod1()
        {
            Console.WriteLine("Overriding abstract method.");
        }
    }
}
