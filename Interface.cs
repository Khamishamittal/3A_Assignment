using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
     interface IAnimal
    {
        void animalSound();
    }
    class Pig: IAnimal
    {
        public void animalSound() 
        {
            Console.WriteLine("cndklmzvn klsn");
        
        }
    }
}
