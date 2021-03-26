using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------------Fibonacci Example--------------------");
            Console.WriteLine("-----------------------------------------------------------");

            int num1 = 0, num2 = 1, num3, num4;
            Console.Write("Enter Number Of Element : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Fibonacci Series Of " + num3 + " Elements is below");
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < num3; i++)
            {
                num4 = num1 + num2;
                Console.Write(num4 + " ");
                num1 = num2;
                num2 = num4;
            }
            Console.ReadKey();
        }
    }
}
