using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    //Abstract Class
    public abstract class Animal1
    {
        //abstract method-

        public abstract void makeSound();

        //non abstract method
        public void Eat()
        {
            Console.WriteLine("Animal");
        }

    }

    //Derived class 1

    public class Dog : Animal1
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog");
        }
    }
    
    //Derved Class 2
    public class Cat:Animal1
    {
        public override void makeSound()
        {
           Console.WriteLine("Cat");
        }
    }
    internal class AbstractCls
    {
        static void Main()
        {
            // object creation for derived class
            Dog dog = new Dog();
            Cat cat = new Cat();

            //call method
            dog.makeSound();
            dog.Eat();
            cat.makeSound();
            cat.Eat();
        }
    }
}
