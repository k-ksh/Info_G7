using System;

namespace Info_G7.OOP
{
    public class Parent
    {
        public int test1;
        protected int test2 = 222;
        public string name = "Parent name";

        public Parent()
        {

        }

        public Parent(string name)
        {
            this.name = name;
        }       

        public void SaySomething()
        {
            Console.WriteLine("I'm parent class.");
        }

        public override string ToString()
        {
            return $"I'm a Parent with name {name}.";
        }
    }
}
