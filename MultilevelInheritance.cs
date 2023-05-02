using _3A_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
    public class Parent
    {
        public void Animal()
        {
            Console.WriteLine("dog");
        }

    }
    class Derived : Parent
    {
        public void Animal2()
        {
            Console.WriteLine("Dog2");
        }
    }
    class Derived2: Derived
    {
        public void Animal3()
        {
            Console.WriteLine("Dog3");
        }
    }
}
