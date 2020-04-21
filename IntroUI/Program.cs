using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                PersonName = "Youdhbir",
                LastName = "Singh"
            };

            System.Console.WriteLine($"My name is {p.PersonName} {p.LastName}");
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is first program in VS code");
        }
    }
}
