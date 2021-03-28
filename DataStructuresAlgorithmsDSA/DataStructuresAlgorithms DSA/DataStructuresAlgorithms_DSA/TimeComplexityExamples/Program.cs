using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexityExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10]; // assume the size of input is very large
            int[] arr2 = new int[10]; // assume the size of input is very large 

            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rng.Next(100, 999);
                arr2[i] = rng.Next(100, 999);
            }

            ConstantTimeComplexity(10000);

            LinearTimeComplexity(arr1);

            QuadraticTimeComplexity(arr1);

            MoreExamples1(arr1, arr2);

            Console.WriteLine("-----------------------");

            MoreExamples2(arr1, arr2);

            Console.WriteLine("-----------------------");

            MoreExamples3(arr1, arr2);
            Console.WriteLine("-----------------------");

            MoreExamples4(arr1, arr2);
            Console.WriteLine("-----------------------");

            MoreExamples5(arr1);
            Console.WriteLine("-----------------------");

            Console.Read();
        }

        static void ConstantTimeComplexity(int n)
        {
            int a = 100;
            int b = 200;

            int sum = a + n;
            int mul = b * n;

            Console.WriteLine("{0}, {1}", sum, mul);
        }

        static void LinearTimeComplexity(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("{0}", arr1[i]);
            }
        }

        static void QuadraticTimeComplexity(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    Console.WriteLine("{0}", arr1[i] + arr1[j]);
                }
            }
        }

        static void MoreExamples1(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                Console.WriteLine(arr2[j]);
            }
        }

        static void MoreExamples2(int[] arr1, int[] arr2)
        {
            for(int i =0;i<arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] > arr2[j])
                    {
                        Console.WriteLine(arr1[i] + " , " + arr2[j]);
                    }
                }
            }
            
        }

        static void MoreExamples3(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    for (int k = 0; k < 100000; k++)
                    {
                        Console.WriteLine(arr1[i] + " , " + arr2[j]);
                    }
                }
            }

        }

        static void MoreExamples4(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    Console.WriteLine(arr1[i] + ", " + arr2[j]);
                }
            }

            for (int k = 0; k < arr1.Length; k++)
            {
                Console.WriteLine(arr1[k]);
            }
        }
        
        static void MoreExamples5(int[] arr1)
        {
            int i = 1;

            while (i < arr1.Length)
            {
                Console.WriteLine(arr1[i]);
                i = i + 2;
            }
        }      
    }
}
