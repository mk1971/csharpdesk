using System;

namespace ExceptionsSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 2, b = 0;
                float z = a / b;
                Console.WriteLine("His will not executed");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("This will always be executed");
            }
        }
    }
}
