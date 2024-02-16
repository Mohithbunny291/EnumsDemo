using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Base class with a constructor that takes a string parameter
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public virtual void age(int Age)
        {
            Console.WriteLine(Age);
        }
        
    }

    // Derived class that inherits from Animal and calls its constructor using base
    class Dog : Animal
    {
        public string Breed { get; set; }

        

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public override void age(int age)
        {
            base.age(200);
            Console.WriteLine(age+" is age");
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Ceetha","vosa");
            Console.WriteLine(dog.Name+" "+ dog.Breed);
            dog.age(100);
            Console.ReadLine();
        }
    }
    
    

}
