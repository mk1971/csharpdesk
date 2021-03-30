using System;

namespace PrefixPostfix_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0, var2 = 0;
            Console.WriteLine("Prefix on return: " + PlusOnePrefix(var1));
            Console.WriteLine("Postfix on return: " + PlusOnePostfix(var2));
        }
        public static int PlusOnePrefix(int x)
        {
            return ++x; // => increments first, and return the result
        }
        public static int PlusOnePostfix(int x)
        {
            return x++; // => return the value x and then increments
        }
    }
}
