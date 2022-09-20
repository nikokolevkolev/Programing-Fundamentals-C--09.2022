using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Modular division by 10-> return last digit
            //Integer division by 10-> removes last digits
            int numCopy = n;
            int factorialSum = 0;
            while (numCopy >0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                // calculate factorial of last digit
                //Stores a product -> start from 1-. 1*n=n;
                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i; // factorial = factorial *i;
                }
                // Suming factorial
                factorialSum += factorial;
            }
            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
