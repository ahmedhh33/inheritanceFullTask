using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_full_task
{
    internal class Animal
    {
        public virtual void MakeNoise() { }
        
        public virtual void Eat() { }   
    }

    internal class Dog : Animal 
    {
        public override void MakeNoise()//to be overrided must the parent method is virtual or override or abstracted
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat dog food.");
        }
        
            
    }

    internal class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat Cat food.");
        }
    }
    
}
