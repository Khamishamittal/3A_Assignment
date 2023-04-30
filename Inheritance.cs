using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
    public class Inheritance1
    {
        public void ParentClass()
        {
            Console.WriteLine("This is parent class");
        }
    }
    public class ChildClass : Inheritance1
    {
        public void Parent2()
        {
            Console.WriteLine("This is derived Class");
        }
    }
}


