using System;

namespace ConsoleMultipleClass
{
    class _2DArray
    {
        static void Main(string[] args)
        {
            _2DArray obj = new _2DArray();
            obj.TwoDArray();
            Console.ReadLine();
        }

        void TwoDArray()
        {
            Console.Write("Define Column Number:- ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.Write("Define Row Number:- ");
            int rowNO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");

            Console.Write("Now Fill Array:- ");

            int[,] TwoDArray = new int[column, rowNO];

            string arrayTemp = Convert.ToString(Console.ReadLine());

            string[] temp = arrayTemp.Split(' ');

            int k = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rowNO; j++)
                {
                    int OneValue = Convert.ToInt32(temp[k]);
                    TwoDArray[i, j] = OneValue;
                    k++;
                }
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < column; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("    Column");
                }

                for (int j = 0; j < rowNO; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Rows " + TwoDArray[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + TwoDArray[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
