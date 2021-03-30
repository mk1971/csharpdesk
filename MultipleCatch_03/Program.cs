using System;

namespace MultipleCatch_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CatchException sampleException = new CatchException();
            sampleException.CustomExceptionSample("CustomException");
            sampleException.CustomExceptionSample("Exception");
        }
    }

    class CatchException
    {
        public void CustomExceptionSample(string ExceptionType)
        {
            try
            {
                switch (ExceptionType)
                {
                    case "CustomException":
                        throw new CustomException();
                    default:
                        throw new Exception();
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine("This is a CustomException");
            }
            catch (Exception e)
            {
                Console.WriteLine("This is NOT a CustomException");
            }
        }
    }
    public class CustomException : Exception
    {
        public CustomException() { }

        public CustomException(string message) : base(message) { }

        public CustomException(string message, Exception inner) : base(message, inner) { }
    }
}
