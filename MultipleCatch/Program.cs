using System;

namespace MultipleCatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CatchException sampleException = new CatchException();
            sampleException.BeforeCSharp6("FormatException");
            sampleException.BeforeCSharp6("OverflowException");
            sampleException.BeforeCSharp6("Exception");
        }
    }
    class CatchException
    {
        public void BeforeCSharp6(string ExceptionType)
        {
            try
            {
                switch (ExceptionType)
                {
                    case "FormatException":
                        throw new FormatException();
                    case "OverflowException":
                        throw new OverflowException();
                    default:
                        throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("This is a FormatException or OverflowException ");
                    return;
                }
                Console.WriteLine("This is NOT a FormatException or OverflowException ");
            }
            return;
        }
    }
}
