using _3A_Assignment;

namespace Day3A_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ClassAndObject obj = new ClassAndObject();
            //obj.Display();

            //ChildClass obj = new ChildClass();
            //obj.ParentClass();
            //obj.Parent2();

            //overloading
            //Polymorphism obj = new Polymorphism();
            //Console.WriteLine(obj.Add(8, 9));
            //Console.WriteLine(obj.Add(6, 5, 3));
            //Console.WriteLine(obj.Add(6.8, 9.7, 6.4));

            //overriding
            //Car obj1 = new Car();
            //obj1.honk();
            //Bus obj2 = new Bus();
            //obj2.honk();
            //Console.ReadKey();

            //Encapsulation obj = new Encapsulation();
            //obj.Name = "Teeeeeeeeeeeeeeeeeeeeeeeennnnnnnnnnnaaaaaaaaaaaaaa";
            //obj.RollNo = 34;
            //Console.WriteLine(obj.RollNo);
            //Console.WriteLine(obj.Name);

            //Lion obj = new Lion();
            //obj.AnimalSound();
            //obj.Bird();
            //Pig obj = new Pig();
            //obj.animalSound();

            Derived obj = new Derived();
            obj.Animal2();
            obj.Animal(); 
           

            Derived2 obj2 = new Derived2();
            obj2.Animal3();
            obj2.Animal2();
            obj.Animal();
            


        }
    }
}