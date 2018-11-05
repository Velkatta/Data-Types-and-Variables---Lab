using System;

namespace _04._Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine((int)Math.Ceiling((double)numberOfPeople/capacity));
        }
    }
}