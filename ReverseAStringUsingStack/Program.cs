using System;
using System.Collections.Generic;

namespace ReverseAStringUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string sInput = Console.ReadLine();
            string sOutput = ReverseAString(sInput);

            Console.WriteLine("\n Reversed String is: " + sOutput);
            Console.Read();
        }

        private static string ReverseAString(string sInput)
        {
            Stack<char> objStack = new Stack<char>();
            string sOutPut = string.Empty;
            if (sInput != null)
            {
                int iInputLength = sInput.Length;

                for (int i = 0; i < iInputLength; i++)
                {
                    objStack.Push(sInput[i]);
                }

                while (objStack.Count != 0)
                {
                    sOutPut += objStack.Pop();
                }
            }
            return sOutPut;
        }
    }
}
