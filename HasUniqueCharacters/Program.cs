using System;

namespace HasUniqueCharacters
{
    /// Write a program to validate if the given string contains unique characters which means that the give string does not contain any character twice or multiple times  
    /// You need to consider that comparison is case non-sensitive and whitespace is significant  
    /// ============================================================  
    /// For example 1:  
    /// Input: s1 = "hemant"  Output: No Duplicate characters found in string  
    /// Explanation: s1 does contain each character one time.  
    /// ============================================================  
    /// For example 2: "hemantH";  
    /// Input: s1 = "hemantH" Output: Duplicate characters found in string  
    /// Explanation: s1 contains character h two times irrespective of case sensitive.  
    ///   
    /// For example 3: "hemant H";  
    /// Input: s1 = "hemantH" Output: Duplicate characters found in string  
    /// Explanation: s1 contains character h two times irrespective of case sensitive and white space is significant.  
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter string to be processed: ");
            var inputString = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(inputString))
            {
                //as per the ASCII standard character set there are 128 characters for electronic communication  
                //so the length of the given string is more than 128 means string contain character multiple times  
                if (inputString.Length > 128)
                {
                    Console.WriteLine("Duplicate characters found in string");
                }

                bool hasUniqueCharacters = HasUniqueCharacters(inputString);
                Console.WriteLine(hasUniqueCharacters ? "No Duplicate characters found in string" : "Duplicate characters found in string");
            }

            Console.ReadLine();
        }

        private static bool HasUniqueCharacters(string inputString)
        {
            string stringToBeProcessed = inputString.Replace(" ", "").ToLower();
            //Convert string into an array f characters   
            char[] chars = stringToBeProcessed.ToCharArray();
            //declare an array of integer type with size 128 because as per the ASCII standard character set  
            //there are 128 characters for electronic communication.  
            int[] characterSetMappingTable = new int[128];

            //Iterate through an array and for the index matching with the character ASCII value,  
            //increment the value in the integer array by 1 if the value is 0 otherwise return false if the value is already 1   
            foreach (char c in chars)
            {
                var characterIndex = (int)c;
                if (characterSetMappingTable[characterIndex] >= 1)
                    return false;
                characterSetMappingTable[characterIndex]++;
            }

            return true;
        }
    }
}
