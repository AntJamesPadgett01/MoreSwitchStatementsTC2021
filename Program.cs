using System;

namespace MoreSwitchStatementsTC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is pretty hard to master.");
                    break;
                case "Science":
                    Console.WriteLine("Science is also tough to grasp.");
                    break;
                case "English":
                    Console.WriteLine("English is a pretty easy subject to master.");
                    break;
                default:
                    Console.WriteLine($"Wow i haven't taken that subject. {subject} sounds interesting.");
                    break;
            }



        }
    }    
        
    
}
