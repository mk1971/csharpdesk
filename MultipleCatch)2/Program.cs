using System;

namespace MultipleCatch_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CatchException sampleException = new CatchException();
            sampleException.AfterCSharp6("FormatException");
            sampleException.AfterCSharp6("OverflowException");
            sampleException.AfterCSharp6("Exception");
        }
    }

    class CatchException
    {
        public void AfterCSharp6(string ExceptionType)
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
            catch (Exception e) when (e is OverflowException || e is FormatException)
            {
                Console.WriteLine("This is a FormatException or OverflowException ");
            }
            catch (Exception e)
            {
                Console.WriteLine("This is NOT a FormatException or OverflowException ");
            }
        }
    }
}
