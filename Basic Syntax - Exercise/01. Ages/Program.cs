using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (n <= 13)
            {
                Console.WriteLine("child");
            }
            else if (n <=19)
            {
                Console.WriteLine("teenager");
            }
            else if (n  <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (n >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
