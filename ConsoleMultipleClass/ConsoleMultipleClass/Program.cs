using System;

namespace ConsoleMultipleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.NeonNumber();
            Console.ReadLine();
        }
        void NeonNumber()
        {
            Console.WriteLine("Enter your number to check number is neon or not");
            int input = Convert.ToInt32(Console.ReadLine());

            int temp = input * input;

            string tempString = Convert.ToString(temp);

            char[] charArray = tempString.ToCharArray();


            int sum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                string sumTemp = Convert.ToString(charArray[i]);
                sum += Convert.ToInt32(sumTemp);
            }

            if (sum == input)
            {
                Console.WriteLine("Number is neon");
            }
            else
            {
                Console.WriteLine("Number is not neon");
            }
        }
    }
}
