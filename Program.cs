using _3A_Assignment;

namespace Day3A_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ClassAndObject obj = new ClassAndObject();
            //obj.Display();

            ChildClass obj = new ChildClass();
            obj.ParentClass();
            obj.Parent2();


            Console.ReadKey();
        }
    }
}