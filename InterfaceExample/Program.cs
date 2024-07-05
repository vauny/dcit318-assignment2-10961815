// See https://aka.ms/new-console-template for more information
using System;

namespace InterfaceExample
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            car.Move();

            IMovable bicycle = new Bicycle();
            bicycle.Move();
        }
    }
}

