using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string name = "Stanko";
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"{name}, do you like cats?");
            Console.Write(">>>");
            string resp = Console.ReadLine();
            if (resp.ToLower().StartsWith("yes"))
            {
                Console.WriteLine("awwwww :3 :3 :3");
            }
            else
            {
                Console.WriteLine(":((((((");
            }

        }
    }
}
