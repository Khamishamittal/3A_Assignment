using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
    // Data abtraction is a process  of hiding certain details and only essential information to user.
    // it is obtained using abtract class or interfaces.
    //abstract class is restricted class  that cannot be used  to create objects.It must be inherited from another class.
    //abstract method can be used only in abtract class. and it doesnot have body. The body  is provided by derived class.
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Bird()
        {
            Console.WriteLine("BDCKJSABCLKAVN");
        }

    }
    class Lion : Animal { 

        public override void AnimalSound()
        {
            Console.WriteLine("tsajysdoiaudpqw");
        }
    }



}
