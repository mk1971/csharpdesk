using System;

namespace ValidatingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first string to be processed: ");
            var firstInputString = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter second string to be processed: ");
            var secondInputString = Console.ReadLine();

            if (CompareLength(firstInputString, secondInputString) == false) // if length difference is more than 1 then more than one edit is required.    
            {
                Console.WriteLine("more than one edit");
            }
            else
            {
                Console.WriteLine(FindEditCount(firstInputString, secondInputString) == false ?
                 "more than one edit is required to convert one string to another" :
                 "only one edit is required to convert one string to another");
            }

            Console.ReadLine();
        }

        private static bool FindEditCount(string firstInputString, string secondInputString)
        {
            // find out longer and smaller string based on the length difference    
            // difference is less than 0 then second given string is the longer string    
            // OR difference is more than 0 then first given string is the longer string    
            // OR difference equals to 0 then both string are of same length    
            string longerString = firstInputString;
            string smallerString = secondInputString;
            int val = longerString.Length - smallerString.Length;

            if (val < 0)
            {
                longerString = secondInputString;
                smallerString = firstInputString;
            }

            int smallerStringIndex = 0;
            int longerStringIndex = 0;
            int editCount = 0;

            char[] longerStringCharacterSet = longerString.ToCharArray();
            char[] smallerStringCharacterSet = smallerString.ToCharArray();

            //continue iterate through string character set while loop reach at the end of longer string length or end of smaller string length    
            while (longerStringCharacterSet.Length > longerStringIndex && smallerStringCharacterSet.Length > smallerStringIndex)
            {
                if (editCount > 1) return false; // if more than one edit found then return failure signal    

                //match character of given strings (longer and smaller) if character match then increment the counter for both smaller and longer string index    
                if (longerStringCharacterSet[longerStringIndex] == smallerStringCharacterSet[smallerStringIndex])
                {
                    longerStringIndex++;
                    smallerStringIndex++;
                }
                else
                {
                    // if do not match always increment the index counter for longer string     
                    longerStringIndex++;
                    if (val == 0)
                        // if do not match and length of smaller and longer is same    
                        // then increment the index counter for smaller string too     
                        smallerStringIndex++;
                    editCount++;
                }
            }

            return true;
        }

        /// <summary>    
        /// Compare the length of two given strings.    
        /// </summary>    
        /// <param name="firstInputString">First given string</param>    
        /// <param name="secondInputString">Second given string</param>    
        /// <returns></returns>    
        private static bool CompareLength(string firstInputString, string secondInputString)
        {
            return Math.Abs(firstInputString.Length - secondInputString.Length) <= 1;
        }
    }
}
