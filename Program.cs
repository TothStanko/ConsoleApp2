using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            {
                string name = "Zoli";
                Console.WriteLine($"Hello, {name}!");
                Console.WriteLine($"{name}, do you like cats?");
                Console.Write(">>>  ");
                string resp = Console.ReadLine();
                if (resp.ToLower().StartsWith("yes"))
                {
                    Console.WriteLine("awwwww :3 :3 :3");
                }
                else Console.WriteLine(":(((((");

                Console.WriteLine("What is your favorite color?");
                Console.Write(">>>  ");
                resp = Console.ReadLine();
                if (resp.ToLower().Contains("blue"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This?");
                }
                else if (resp.ToLower().Contains("red"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This?");
                }
                else if (resp.ToLower().Contains("green"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("This?");
                }
                Console.ReadKey(true);

            }
 }  }    }   

