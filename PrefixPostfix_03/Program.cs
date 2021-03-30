using System;

namespace PrefixPostfix_03
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
            ++x;
            return x;
        }
        public static int PlusOnePostfix(int x)
        {
            x++;
            return x;
        }
    }
}
