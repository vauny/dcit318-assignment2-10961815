﻿// See https://aka.ms/new-console-template for more inf


using System;

namespace InheritanceExample
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }

    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }    
    }

    class Program
    {
        static void Main(string[] args)
        {
        Animal genericAnimal = new Animal();
        genericAnimal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
        }
    }
    
}