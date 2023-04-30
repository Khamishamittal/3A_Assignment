using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
    public class Polymorphism
    {
        //overloading
        public int Add(int x, int y)
        {
            return x + y;

        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    //overriding
    public class Vehicle
    {
        public virtual void honk()
        {
            Console.WriteLine("pi pi pi pi");
        }
    }

    public class Car: Vehicle
    {
        public override void honk()
        {
            Console.WriteLine("tututututuuuuuuuuuuuuuuuuu");
        }
    }

    public class Bus : Vehicle
    {
        public override void honk()
        {
            Console.WriteLine("tiititititititiiiiiiiiiiii");
        }
    }
}







