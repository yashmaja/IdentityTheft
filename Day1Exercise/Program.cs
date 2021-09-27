using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity Stealer!");
            
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter your hometown: ");
            string homeTown = Console.ReadLine();

            //Console.WriteLine("\n\n Your name is " + name + ".\n Your age is " + age + ".\n Your hometown is " + homeTown + ".");
            Console.WriteLine($"\n\nYour name is {name}. \nYour age is {age}. \nYour hometown is {homeTown}.");

        }
    }
}
