using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            switch (type)
            {
                case "Students":
                    if (peopleCount >= 30)
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = (peopleCount * 8.45) - ((peopleCount * 8.45) * 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = (peopleCount * 9.80) - ((peopleCount * 9.80) * 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = (peopleCount * 10.46) - ((peopleCount * 10.46) * 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = peopleCount * 8.45;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = peopleCount * 9.80;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = peopleCount * 10.46;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
                case "Business":
                    if (peopleCount >= 100)
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = (peopleCount * 10.90) -((peopleCount-10)* 10.90);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = (peopleCount * 15.60) - ((peopleCount - 10) * 15.60);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = totalPrice = (peopleCount * 16.00) - ((peopleCount - 10) * 16.00);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = peopleCount * 10.90;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = peopleCount * 15.60;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = peopleCount * 16;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
                case "Regular":
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = (peopleCount * 15) - ((peopleCount * 15) * 0.05);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = (peopleCount * 20) - ((peopleCount * 20) * 0.05);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = totalPrice = (peopleCount * 22.50) - ((peopleCount * 22.50) * 0.05);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else
                    {
                        if (dayOfWeek == "Friday")
                        {
                            totalPrice = peopleCount * 15;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else if (dayOfWeek == "Saturday")
                        {
                            totalPrice = peopleCount * 20;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else // Sunday
                        {
                            totalPrice = peopleCount * 22.50;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
