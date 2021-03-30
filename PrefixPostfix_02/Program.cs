using System;

namespace PrefixPostfix_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (++x < 3)
            {
                Console.WriteLine("Using Prefix, x value is: " + x);
            }
            x = 0;
            while (x++ < 3)
            {
                Console.WriteLine("Using Postfix, x value is: " + x);
            }
        }
    }
}
